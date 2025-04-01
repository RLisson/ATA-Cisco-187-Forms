namespace ATA_Cisco_187
{
    partial class FrmConfig
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
            this.textFtpPort = new System.Windows.Forms.TextBox();
            this.labelMac = new System.Windows.Forms.Label();
            this.textFtpPass = new System.Windows.Forms.TextBox();
            this.labelFtpPass = new System.Windows.Forms.Label();
            this.textFtpUser = new System.Windows.Forms.TextBox();
            this.labelFtpUser = new System.Windows.Forms.Label();
            this.textFtpServer = new System.Windows.Forms.TextBox();
            this.ftpServerLabel = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFtpPort
            // 
            this.textFtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFtpPort.Location = new System.Drawing.Point(122, 138);
            this.textFtpPort.Name = "textFtpPort";
            this.textFtpPort.Size = new System.Drawing.Size(145, 26);
            this.textFtpPort.TabIndex = 15;
            // 
            // labelMac
            // 
            this.labelMac.AutoSize = true;
            this.labelMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMac.Location = new System.Drawing.Point(28, 144);
            this.labelMac.Name = "labelMac";
            this.labelMac.Size = new System.Drawing.Size(71, 20);
            this.labelMac.TabIndex = 14;
            this.labelMac.Text = "FTP Port";
            // 
            // textFtpPass
            // 
            this.textFtpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFtpPass.Location = new System.Drawing.Point(122, 102);
            this.textFtpPass.Name = "textFtpPass";
            this.textFtpPass.Size = new System.Drawing.Size(145, 26);
            this.textFtpPass.TabIndex = 13;
            // 
            // labelFtpPass
            // 
            this.labelFtpPass.AutoSize = true;
            this.labelFtpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFtpPass.Location = new System.Drawing.Point(28, 102);
            this.labelFtpPass.Name = "labelFtpPass";
            this.labelFtpPass.Size = new System.Drawing.Size(77, 20);
            this.labelFtpPass.TabIndex = 12;
            this.labelFtpPass.Text = "FTP Pass";
            // 
            // textFtpUser
            // 
            this.textFtpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFtpUser.Location = new System.Drawing.Point(122, 57);
            this.textFtpUser.Name = "textFtpUser";
            this.textFtpUser.Size = new System.Drawing.Size(145, 26);
            this.textFtpUser.TabIndex = 11;
            // 
            // labelFtpUser
            // 
            this.labelFtpUser.AutoSize = true;
            this.labelFtpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFtpUser.Location = new System.Drawing.Point(28, 60);
            this.labelFtpUser.Name = "labelFtpUser";
            this.labelFtpUser.Size = new System.Drawing.Size(76, 20);
            this.labelFtpUser.TabIndex = 10;
            this.labelFtpUser.Text = "FTP User";
            // 
            // textFtpServer
            // 
            this.textFtpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFtpServer.Location = new System.Drawing.Point(122, 15);
            this.textFtpServer.Name = "textFtpServer";
            this.textFtpServer.Size = new System.Drawing.Size(145, 26);
            this.textFtpServer.TabIndex = 9;
            this.textFtpServer.TextChanged += new System.EventHandler(this.textFtpServer_TextChanged);
            // 
            // ftpServerLabel
            // 
            this.ftpServerLabel.AutoSize = true;
            this.ftpServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpServerLabel.Location = new System.Drawing.Point(28, 18);
            this.ftpServerLabel.Name = "ftpServerLabel";
            this.ftpServerLabel.Size = new System.Drawing.Size(88, 20);
            this.ftpServerLabel.TabIndex = 8;
            this.ftpServerLabel.Text = "FTP Server";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(164, 180);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 16;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 215);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.textFtpPort);
            this.Controls.Add(this.labelMac);
            this.Controls.Add(this.textFtpPass);
            this.Controls.Add(this.labelFtpPass);
            this.Controls.Add(this.textFtpUser);
            this.Controls.Add(this.labelFtpUser);
            this.Controls.Add(this.textFtpServer);
            this.Controls.Add(this.ftpServerLabel);
            this.Name = "FrmConfig";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFtpPort;
        private System.Windows.Forms.Label labelMac;
        private System.Windows.Forms.TextBox textFtpPass;
        private System.Windows.Forms.Label labelFtpPass;
        private System.Windows.Forms.TextBox textFtpUser;
        private System.Windows.Forms.Label labelFtpUser;
        private System.Windows.Forms.TextBox textFtpServer;
        private System.Windows.Forms.Label ftpServerLabel;
        private System.Windows.Forms.Button btnApply;
    }
}