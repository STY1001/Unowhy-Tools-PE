using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unowhy_Tools_PE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void powerbtn_Click(object sender, EventArgs e)
        {
            var power = new Power();
            power.ShowDialog();
        }

        private void cmdbtn_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void eppbtn_Click(object sender, EventArgs e)
        {
            Process.Start("epp.exe");
        }

        private void lsprbtn_Click(object sender, EventArgs e)
        {
            Process.Start("lsrs\\PasswordRecoveryApp.exe");
        }

        private void utbubtn_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k \"utbu\\AutoFlash.bat\"");
        }

        private void wlubtn_Click(object sender, EventArgs e)
        {
            Process.Start("wlu\\WLU.exe");
        }
    }
}
