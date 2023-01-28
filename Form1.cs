using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConnectToSqlDatabase
{
    public partial class Main : Form
    {
        public bool conWindowOpen = false; //true = Form2 Open / false = Form2 Closed
        public string sqlConnectionString  = string.Empty; //use this for opening connection to the SQL server in this form
        public string dbVersion = string.Empty; //Only used if the currentVersion() method is uncommented and setup

        public Main()
        {
            InitializeComponent();
        }

        public void closeConnectionWindowEvent()
        {
           if (dbVersion != string.Empty)
            {
                labDataStatus.ForeColor = Color.Green;
                labDataStatus.Text = "Connected";
                labDataVersion.ForeColor = Color.Blue;
                labDataVersion.Text = dbVersion;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!conWindowOpen) {
                DatabaseConnection databaseConnection = new DatabaseConnection(this);
                databaseConnection.StartPosition = FormStartPosition.CenterParent;
                databaseConnection.Show();
                conWindowOpen = true;
            }

            labDataStatus.ForeColor = Color.Red;
            labDataStatus.Text = "Not Connected";
            labDataVersion.ForeColor = Color.Black;
            labDataVersion.Text = "-";
        }
    }
}
