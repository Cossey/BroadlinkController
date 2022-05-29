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
    public partial class WirelessDetails : Form
    {
        public WirelessDetails()
        {
            InitializeComponent();

            SecurityDropdown.SelectedIndex = 0;
        }


        public string SSID;
        public string Password;
        public SharpBroadlink.Broadlink.WifiSecurityMode Security = SharpBroadlink.Broadlink.WifiSecurityMode.None;


        public DialogResult ShowDialog(string[] ssids)
        {
            SSIDBox.Items.Clear();
            SSIDBox.Items.AddRange(ssids);
            return ShowDialog();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SSID = SSIDBox.Text;
            Password = PasswordBox.Text;
            Security = (SharpBroadlink.Broadlink.WifiSecurityMode)SecurityDropdown.SelectedIndex;
        }
    }
}
