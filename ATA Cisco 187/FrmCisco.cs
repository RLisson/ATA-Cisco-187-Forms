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
        private FrmConfig frmConfig = new FrmConfig();
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
            frmConfig.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
