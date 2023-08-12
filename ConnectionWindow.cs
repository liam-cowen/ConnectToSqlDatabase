using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ConnectToSqlDatabase
{
    public partial class DatabaseConnection : Form
    {
        private Main _mainForm;
        public string sqlConnectionString = string.Empty;
        public bool usingWinAuth = false;

        public DatabaseConnection(Main main)
        {
            InitializeComponent();
            _mainForm = main;
        }

        //selects which string builder method to use (based on Win auth) - checks that forms are filled in first with "verifyConnectionDetails()" method
        private bool verifyConnectionDetails()
        {
            bool verifiedFields = checkTextInConnectionDetails();
           
            if (verifiedFields)
            {
                switch (usingWinAuth)
                {
                    case true:
                        sqlConnectionString = sqlConnectionBuilderWinAuth(comboSqlServers.Text, comboDatabases.Text);
                        break;
                    case false:
                        sqlConnectionString = sqlConnectionBuilder(comboSqlServers.Text, comboDatabases.Text, textUser.Text, textPassword.Text);
                        break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //checks that text is in the "Server" and "Database" fields and that either Windows Auth is check or "user" and "password" have text filled in
        private bool checkTextInConnectionDetails() 
        {
            if (comboSqlServers.Text.Length > 0 &&
                comboDatabases.Text.Length > 0 && (
                usingWinAuth ||
                textUser.Text.Length > 0 &&
                textPassword.Text.Length > 0))
            {
                return true;    
            }
            else
            {
                MessageBox.Show("Please ensure all details are entered correctly!");
                return false;
            }
        }

        //Method for retrieving version (if applicable). Change the SQL query in the Sqlcommand brackets
        //Currently it stores the version as a number (int) - can can to string if text is needed
        //If no version is available an error will be produced stating the database is invalid
        //Even if there isn't a database version, this can be used to ensure the tool is connecting to a valid DB

        /*
        public void currentVersion(SqlConnection con)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DBVersion FROM DbVersionTable", con);

                int versionNumber = (Int32)cmd.ExecuteScalar();
                _mainForm.dbVersion = versionNumber.ToString();
                con.Close();

                return; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Database" + Environment.NewLine + ex.Message, "Invalid DB");
                return;
            }
        }
        */

        //uses passed variables to create the SQL connection string
        public string sqlConnectionBuilder(string server, string database, string user, string password) 
        {
            string sqlConnection = "Data Source = ";
            sqlConnection += server + ";Initial Catalog=" + database + ";Integrated Security=false;User ID=" + user + ";Password=" + password + ";";

            return sqlConnection;
        }

        //uses passed variables to create the SQL string for Win Auth connection
        public string sqlConnectionBuilderWinAuth(string server, string database) 
        {
            string sqlConnection = "Data Source = ";
            sqlConnection += server + ";Initial Catalog=" + database + ";Integrated Security=true";

            return sqlConnection;
        }

        //Uses entered server and either win auth or user/password to connect to the SQL server instance and return a list of databases
        public string sqlConnnectionForDatabases()
        {
            string conString = string.Empty;

            if (comboSqlServers.Text.Length > 0)
            {
                switch (checkWinAuth.Checked)
                {
                    case true:
                        conString = "server=" + comboSqlServers.Text + ";Integrated Security=true";
                        break;
                    case false:
                        if (textUser.Text.Length > 0 && textPassword.Text.Length > 0)
                        {
                            conString = "server=" + comboSqlServers.Text + ";uid=" + textUser.Text + ";pwd=" + textPassword.Text;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a username and password. Or use Windows Authentication");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Please enter a SQL server instance");
            }
            return conString;
        }

        //creates the XML formatting to save to XML
        private string xmlBuilder()
        {
            string xml = "<settings><server>" + comboSqlServers.Text + "</server>" +
                "<user>" + textUser.Text + "</user>" +
                "<winauth>" + checkWinAuth.Checked + "</winauth>" +
                "<password>" + textPassword.Text + "</password>" +
                "<database>" + comboDatabases.Text + "</database></settings>";

            return xml;
        }

        //if checked, will saved connection details to "connection.xml" on connection - will be loaded from in future use
        private void saveToXml()
        {
            string xml = xmlBuilder();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            xmlDocument.PreserveWhitespace = true;
            xmlDocument.Save("connection.xml");
        }

        //Removes system databases from the list of options
        private void cleanUpDatabaseCombobox ()
        {
            comboDatabases.Items.Remove("master");
            comboDatabases.Items.Remove("model");
            comboDatabases.Items.Remove("msdb");
            comboDatabases.Items.Remove("tempdb");
        }

        //clears list of servers and gets new list
        private void btnRefreshSqlServers_Click(object sender, EventArgs e)
        {
            comboSqlServers.Items.Clear();  

            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((dt.Rows[i]["InstanceName"] as string) != null)
                    comboSqlServers.Items.Add(dt.Rows[i]["ServerName"] + "\\" + dt.Rows[i]["InstanceName"]);
                else
                    comboSqlServers.Items.Add(dt.Rows[i]["ServerName"]);
            }
            comboSqlServers.SelectedIndex = 0;
        }

        //clears existing list of databases and gets new list - requires Server formed filled in and either Win auth or user/pass
        private void btnRefreshDatabases_Click(object sender, EventArgs e)
        {
            comboDatabases.Items.Clear();  

            string conStringForDatabases = sqlConnnectionForDatabases();

            try
            {
                SqlConnection con = new SqlConnection(conStringForDatabases);
                con.Open();

                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases ORDER BY name", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                comboDatabases.Items.Add(dr[0].ToString());
                                cleanUpDatabaseCombobox();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Could not connect to DB");
            }
            if(comboDatabases.Items.Count > 0)
            {
                comboDatabases.SelectedIndex = 0;
            }
        }

        //enables/disables the user and password forms when the Win Auth option is checked
        private void checkWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if(checkWinAuth.Checked)
            {
                textUser.Enabled = false;
                textPassword.Enabled = false;
                usingWinAuth = true;
            }
            else
            {
                textUser.Enabled=true;
                textPassword.Enabled=true;  
                usingWinAuth = false;
            }
        }

        //Closes window, sets main form bool back to false
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.conWindowOpen = false;
        }

        //If window is closed by other means, sets main form bool back to false
        private void DatabaseConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.conWindowOpen = false;
        }

        //Tests the connection details - provides error message if one is generated
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (verifyConnectionDetails())
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connection Successful", "Success!");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Unsuccessful!" + Environment.NewLine + Environment.NewLine + ex.Message);
                }
            }         
        }

        //Checks connection details - if succesfull, the window is closed and the connection string is passed back to the main form
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(verifyConnectionDetails())
            {
                SqlConnection con = new SqlConnection(sqlConnectionString);

                //Use with above commented out method - this will run a query to find a software/database version
                //if this exists in the database. This updates a text element on the main form

                //currentVersion(con);
                
                //test the connection
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        _mainForm.conWindowOpen = false;
                        _mainForm.sqlConnectionString = sqlConnectionString;
                        _mainForm.closeConnectionWindowEvent();

                        if (checkSaveSettings.Checked)
                        {
                            saveToXml();
                        }
                        this.Close();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Unsuccessful!" + Environment.NewLine + Environment.NewLine + ex.Message);
                }
            }
        }

        //Loads saved connection details from XML file
        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            if(File.Exists("connection.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("connection.xml");
                XmlNode node = xmlDoc.SelectSingleNode("/settings");

                checkWinAuth.Checked = Convert.ToBoolean(node.SelectSingleNode("winauth").InnerText);
                comboSqlServers.Text = node.SelectSingleNode("server").InnerText;
                comboDatabases.Text = node.SelectSingleNode("database").InnerText; 
                textUser.Text = node.SelectSingleNode("user").InnerText; 
                textPassword.Text = node.SelectSingleNode("password").InnerText;              
            }
        }
    }
}
