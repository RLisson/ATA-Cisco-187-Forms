using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATA_Cisco_187
{
    public partial class FrmConfig : Form
    {
        public string FTPServer { get; set; }
        public string FTPUser { get; set; }
        public string FTPPass { get; set; }
        public int FTPPort { get; set; }
        public FrmConfig()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmConfig_Load);
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FTPServer))
            {
                textFtpServer.Text = FTPServer;
            }
            if (!string.IsNullOrEmpty(FTPUser))
            {
                textFtpUser.Text = FTPUser;
            }
            if (!string.IsNullOrEmpty(FTPPass))
            {
                textFtpPass.Text = FTPPass;
            }
            if (FTPPort != 0)
            {
                textFtpPort.Text = FTPPort.ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FTPServer = textFtpServer.Text;
            FTPUser = textFtpUser.Text;
            FTPPass = textFtpPass.Text;
            FTPPort = int.Parse(textFtpPort.Text);

            this.Close();
        }

        private void textFtpServer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
