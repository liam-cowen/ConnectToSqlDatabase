using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConnectToSqlDatabase
{
    public partial class Main : Form
    {
        public bool conWindowOpen = false; //true = Form2 Open : false = Form2 Closed
        public string sqlConnectionString  = string.Empty; //variable to hold the SQL connection string - variable is set from details entered in ConnectionWindow form (if succesful connection is established)
        public string dbVersion = string.Empty; //Only used if the currentVersion() method is uncommented in ConnectionWindow.cs

        public Main()
        {
            InitializeComponent();
        }

        public void closeConnectionWindowEvent()
        {
            // Changes text to "connected" and changes colour to green
            if (sqlConnectionString != string.Empty) { 
                labDataStatus.ForeColor = Color.Green;
                labDataStatus.Text = "Connected";
                textBoxConnectionString.Text = sqlConnectionString; //shows connection string in text box -  for testing the connection
                //labDataVersion.ForeColor = Color.Blue;
                //labDataVersion.Text = dbVersion;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {   //checks if connection window is already open before opening
            if (!conWindowOpen) {
                DatabaseConnection databaseConnection = new DatabaseConnection(this);
                databaseConnection.StartPosition = FormStartPosition.CenterParent;
                databaseConnection.Show();
                conWindowOpen = true;
            }
            //resets text and colour
            labDataStatus.ForeColor = Color.Red;
            labDataStatus.Text = "Not Connected";
            labDataVersion.ForeColor = Color.Black;
            labDataVersion.Text = "-";
        }
    }
}
