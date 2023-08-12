namespace ConnectToSqlDatabase
{
    partial class DatabaseConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnection));
            this.labConnectionWindowTitle = new System.Windows.Forms.Label();
            this.labSqlServer = new System.Windows.Forms.Label();
            this.labDatabase = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkWinAuth = new System.Windows.Forms.CheckBox();
            this.comboSqlServers = new System.Windows.Forms.ComboBox();
            this.comboDatabases = new System.Windows.Forms.ComboBox();
            this.btnRefreshSqlServers = new System.Windows.Forms.Button();
            this.btnRefreshDatabases = new System.Windows.Forms.Button();
            this.checkSaveSettings = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labConnectionWindowTitle
            // 
            this.labConnectionWindowTitle.AutoSize = true;
            this.labConnectionWindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConnectionWindowTitle.Location = new System.Drawing.Point(24, 17);
            this.labConnectionWindowTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labConnectionWindowTitle.Name = "labConnectionWindowTitle";
            this.labConnectionWindowTitle.Size = new System.Drawing.Size(387, 44);
            this.labConnectionWindowTitle.TabIndex = 0;
            this.labConnectionWindowTitle.Text = "Connect to database";
            // 
            // labSqlServer
            // 
            this.labSqlServer.AutoSize = true;
            this.labSqlServer.Location = new System.Drawing.Point(26, 100);
            this.labSqlServer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labSqlServer.Name = "labSqlServer";
            this.labSqlServer.Size = new System.Drawing.Size(123, 25);
            this.labSqlServer.TabIndex = 1;
            this.labSqlServer.Text = "SQL Server";
            // 
            // labDatabase
            // 
            this.labDatabase.AutoSize = true;
            this.labDatabase.Location = new System.Drawing.Point(26, 425);
            this.labDatabase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labDatabase.Name = "labDatabase";
            this.labDatabase.Size = new System.Drawing.Size(104, 25);
            this.labDatabase.TabIndex = 3;
            this.labDatabase.Text = "Database";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(226, 240);
            this.textUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(530, 31);
            this.textUser.TabIndex = 6;
            this.textUser.Text = "sa";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(26, 246);
            this.labUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(110, 25);
            this.labUser.TabIndex = 5;
            this.labUser.Text = "Username";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(226, 312);
            this.textPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(530, 31);
            this.textPassword.TabIndex = 8;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(26, 317);
            this.labPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(106, 25);
            this.labPassword.TabIndex = 7;
            this.labPassword.Text = "Password";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(226, 498);
            this.btnTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(200, 44);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test Settings";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(560, 498);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 44);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(560, 571);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkWinAuth
            // 
            this.checkWinAuth.AutoSize = true;
            this.checkWinAuth.Location = new System.Drawing.Point(226, 188);
            this.checkWinAuth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkWinAuth.Name = "checkWinAuth";
            this.checkWinAuth.Size = new System.Drawing.Size(274, 29);
            this.checkWinAuth.TabIndex = 13;
            this.checkWinAuth.Text = "Windows Authentication";
            this.checkWinAuth.UseVisualStyleBackColor = true;
            this.checkWinAuth.CheckedChanged += new System.EventHandler(this.checkWinAuth_CheckedChanged);
            // 
            // comboSqlServers
            // 
            this.comboSqlServers.FormattingEnabled = true;
            this.comboSqlServers.Location = new System.Drawing.Point(226, 100);
            this.comboSqlServers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboSqlServers.Name = "comboSqlServers";
            this.comboSqlServers.Size = new System.Drawing.Size(466, 33);
            this.comboSqlServers.TabIndex = 14;
            // 
            // comboDatabases
            // 
            this.comboDatabases.FormattingEnabled = true;
            this.comboDatabases.Location = new System.Drawing.Point(226, 425);
            this.comboDatabases.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboDatabases.Name = "comboDatabases";
            this.comboDatabases.Size = new System.Drawing.Size(466, 33);
            this.comboDatabases.TabIndex = 15;
            // 
            // btnRefreshSqlServers
            // 
            this.btnRefreshSqlServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSqlServers.Location = new System.Drawing.Point(708, 100);
            this.btnRefreshSqlServers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefreshSqlServers.Name = "btnRefreshSqlServers";
            this.btnRefreshSqlServers.Size = new System.Drawing.Size(52, 44);
            this.btnRefreshSqlServers.TabIndex = 16;
            this.btnRefreshSqlServers.Text = "⟳";
            this.btnRefreshSqlServers.UseVisualStyleBackColor = true;
            this.btnRefreshSqlServers.Click += new System.EventHandler(this.btnRefreshSqlServers_Click);
            // 
            // btnRefreshDatabases
            // 
            this.btnRefreshDatabases.FlatAppearance.BorderSize = 0;
            this.btnRefreshDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDatabases.Location = new System.Drawing.Point(708, 425);
            this.btnRefreshDatabases.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshDatabases.Name = "btnRefreshDatabases";
            this.btnRefreshDatabases.Size = new System.Drawing.Size(52, 44);
            this.btnRefreshDatabases.TabIndex = 17;
            this.btnRefreshDatabases.Text = "⟳";
            this.btnRefreshDatabases.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRefreshDatabases.UseVisualStyleBackColor = true;
            this.btnRefreshDatabases.Click += new System.EventHandler(this.btnRefreshDatabases_Click);
            // 
            // checkSaveSettings
            // 
            this.checkSaveSettings.AutoSize = true;
            this.checkSaveSettings.Checked = true;
            this.checkSaveSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSaveSettings.Location = new System.Drawing.Point(226, 583);
            this.checkSaveSettings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkSaveSettings.Name = "checkSaveSettings";
            this.checkSaveSettings.Size = new System.Drawing.Size(273, 29);
            this.checkSaveSettings.TabIndex = 18;
            this.checkSaveSettings.Text = "Save conection settings";
            this.checkSaveSettings.UseVisualStyleBackColor = true;
            // 
            // DatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.checkSaveSettings);
            this.Controls.Add(this.btnRefreshDatabases);
            this.Controls.Add(this.btnRefreshSqlServers);
            this.Controls.Add(this.comboDatabases);
            this.Controls.Add(this.comboSqlServers);
            this.Controls.Add(this.checkWinAuth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labDatabase);
            this.Controls.Add(this.labSqlServer);
            this.Controls.Add(this.labConnectionWindowTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DatabaseConnection";
            this.Text = "Database Connection Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseConnection_FormClosing);
            this.Load += new System.EventHandler(this.DatabaseConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labConnectionWindowTitle;
        private System.Windows.Forms.Label labSqlServer;
        private System.Windows.Forms.Label labDatabase;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkWinAuth;
        private System.Windows.Forms.ComboBox comboSqlServers;
        private System.Windows.Forms.ComboBox comboDatabases;
        private System.Windows.Forms.Button btnRefreshSqlServers;
        private System.Windows.Forms.Button btnRefreshDatabases;
        private System.Windows.Forms.CheckBox checkSaveSettings;
    }
}