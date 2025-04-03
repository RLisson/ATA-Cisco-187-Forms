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
    public partial class FrmCisco : Form
    {
        private ATAConfig config;
        private FTPServer ftpServer;
        public FrmCisco()
        {
            InitializeComponent();
        }

        private void textServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMac_TextChanged(object sender, EventArgs e)
        {

        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmConfig frmConfig = new FrmConfig())
            {
                if (ftpServer != null)
                {
                    frmConfig.FTPServer = ftpServer.IP;
                    frmConfig.FTPUser = ftpServer.User;
                    frmConfig.FTPPass = ftpServer.Pass;
                    frmConfig.FTPPort = ftpServer.Port;
                }
                else
                {
                    frmConfig.FTPServer = "Server";
                    frmConfig.FTPUser = "User";
                    frmConfig.FTPPass = "Pass";
                    frmConfig.FTPPort = 21;
                }
                frmConfig.ShowDialog();
                ftpServer = new FTPServer(frmConfig.FTPServer, frmConfig.FTPUser, frmConfig.FTPPass, frmConfig.FTPPort);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            config = new ATAConfig(textServer.Text, textUser.Text, textPass.Text, textMac.Text,
                ftpServer);
            config.UploadFile();
            MessageBox.Show("Configuração enviada com sucesso!");
            ClearText();
        }

        private void ClearText()
        {
            textServer.Clear();
            textUser.Clear();
            textPass.Clear();
            textMac.Clear();
        }
    }
}
