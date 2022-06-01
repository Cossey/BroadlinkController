using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadlink_Controller
{
    public partial class HeatPump : Form
    {
        public HeatPump()
        {
            InitializeComponent();
        }

        private void DryMode_CheckedChanged(object sender, EventArgs e)
        {
            DryNoFan.Enabled = DryMode.Checked;
        }

        private void FanMode_CheckedChanged(object sender, EventArgs e)
        {
            FanNoTemp.Enabled = FanMode.Checked;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
