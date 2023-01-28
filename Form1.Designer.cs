namespace ConnectToSqlDatabase
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnConnect = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.labTitle2 = new System.Windows.Forms.Label();
            this.labConnnect = new System.Windows.Forms.Label();
            this.labStatus = new System.Windows.Forms.Label();
            this.labDataStatus = new System.Windows.Forms.Label();
            this.labDataVersion = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(308, 146);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 44);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(194, 17);
            this.labTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(158, 73);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Title";
            // 
            // labTitle2
            // 
            this.labTitle2.AutoSize = true;
            this.labTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labTitle2.Location = new System.Drawing.Point(202, 88);
            this.labTitle2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTitle2.Name = "labTitle2";
            this.labTitle2.Size = new System.Drawing.Size(95, 31);
            this.labTitle2.TabIndex = 2;
            this.labTitle2.Text = "Title 2";
            // 
            // labConnnect
            // 
            this.labConnnect.AutoSize = true;
            this.labConnnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.labConnnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labConnnect.Location = new System.Drawing.Point(30, 152);
            this.labConnnect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labConnnect.Name = "labConnnect";
            this.labConnnect.Size = new System.Drawing.Size(252, 30);
            this.labConnnect.TabIndex = 3;
            this.labConnnect.Text = "Connect to Database";
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.labStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatus.Location = new System.Drawing.Point(30, 204);
            this.labStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(92, 30);
            this.labStatus.TabIndex = 4;
            this.labStatus.Text = "Status:";
            // 
            // labDataStatus
            // 
            this.labDataStatus.AutoSize = true;
            this.labDataStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.labDataStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labDataStatus.Location = new System.Drawing.Point(136, 204);
            this.labDataStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labDataStatus.Name = "labDataStatus";
            this.labDataStatus.Size = new System.Drawing.Size(187, 29);
            this.labDataStatus.TabIndex = 5;
            this.labDataStatus.Text = "Not Connected";
            // 
            // labDataVersion
            // 
            this.labDataVersion.AutoSize = true;
            this.labDataVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.labDataVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataVersion.Location = new System.Drawing.Point(654, 204);
            this.labDataVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labDataVersion.Name = "labDataVersion";
            this.labDataVersion.Size = new System.Drawing.Size(22, 29);
            this.labDataVersion.TabIndex = 7;
            this.labDataVersion.Text = "-";
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.labVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVersion.Location = new System.Drawing.Point(548, 204);
            this.labVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(107, 30);
            this.labVersion.TabIndex = 6;
            this.labVersion.Text = "Version:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 1306);
            this.Controls.Add(this.labDataVersion);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.labDataStatus);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.labConnnect);
            this.Controls.Add(this.labTitle2);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.Text = "Main Form Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labTitle2;
        private System.Windows.Forms.Label labConnnect;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labDataStatus;
        private System.Windows.Forms.Label labDataVersion;
        private System.Windows.Forms.Label labVersion;
    }
}

