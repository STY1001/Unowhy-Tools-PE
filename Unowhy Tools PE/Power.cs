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
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shutbtn_Click(object sender, EventArgs e)
        {
            Process.Start("wpeutil", "shutdown");
        }

        private void rebootbtn_Click(object sender, EventArgs e)
        {
            Process.Start("wpeutil", "reboot");
        }
    }
}
