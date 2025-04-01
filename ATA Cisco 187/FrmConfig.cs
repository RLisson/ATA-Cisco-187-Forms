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
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FTPServer = textFtpServer.Text;
            FTPUser = textFtpUser.Text;
            FTPPass = textFtpPass.Text;
            FTPPort = int.Parse(textFtpPort.Text);
        }
    }
}
