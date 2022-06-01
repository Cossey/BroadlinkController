using Broadlink_Controller.Device;
using System;
using System.Windows.Forms;
using SharpBroadlink;
using System.Threading.Tasks;
using SharpBroadlink.Devices;
using System.Net.NetworkInformation;
using ManagedNativeWifi;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Broadlink_Controller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CodeConverterMenu.Click += CodeConverterMenu_Click;
            ScanMenu.Click += ScanMenu_Click;
            AddToNetworkMenu.Click += AddToNetworkMenu_Click;
            CopyIPAddress.Click += CopyIPAddress_Click;
            CopyMACAddress.Click += CopyMACAddress_Click;
            SaveListMenu.Click += SaveListMenu_Click;
            LoadListMenu.Click += LoadListMenu_Click;
            HelpHelpMenu.Click += HelpHelpMenu_Click;
            AboutMenu.Click += AboutMenu_Click;
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Broadlink Controller\nVersion {0}\nCopyright 2022 Stewart Cossey", Application.ProductVersion.ToString()), "About");
        }

        private void HelpHelpMenu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void LoadListMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";
            ofd.Title = "Open Scan";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Devices.Items.Clear();
                string sep = ",";

                string[] lines = await File.ReadAllLinesAsync(ofd.FileName);

                foreach (string line in lines)
                {
                    string[] cols = line.Split(sep);
                    ListViewItem lvi = Devices.Items.Add(cols[0]);
                    lvi.SubItems.Add(cols[1]);
                    lvi.SubItems.Add(cols[2]);
                    lvi.SubItems.Add(cols[3]);
                }
            }
        }

        private async void SaveListMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            sfd.Title = "Save Scan";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string sep = ",";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < Devices.Items.Count; i++)
                {
                    sb.Append(Devices.Items[i].Text);
                    sb.Append(sep);
                    sb.Append(Devices.Items[i].SubItems[1].Text);
                    sb.Append(sep);
                    sb.Append(Devices.Items[i].SubItems[2].Text);
                    sb.Append(sep);
                    sb.AppendLine(Devices.Items[i].SubItems[3].Text);
                }

                await File.WriteAllTextAsync(sfd.FileName, sb.ToString());
            }
        }

        private void CopyMACAddress_Click(object sender, EventArgs e)
        {
            if (Devices.SelectedIndices.Count > 0)
            {
                Clipboard.SetText(Devices.Items[Devices.SelectedIndices[0]].SubItems[2].Text);
                CommitLog(1, string.Format("Copy {0} to clipboard", Devices.Items[Devices.SelectedIndices[0]].SubItems[2].Text));
            }
        }

        private void CopyIPAddress_Click(object sender, EventArgs e)
        {
            if (Devices.SelectedIndices.Count > 0)
            {
                Clipboard.SetText(Devices.Items[Devices.SelectedIndices[0]].Text);
                CommitLog(1, string.Format("Copy {0} to clipboard", Devices.Items[Devices.SelectedIndices[0]].Text));
            }
        }

        WirelessDetails wd = new WirelessDetails();
        private async void AddToNetworkMenu_Click(object sender, EventArgs e)
        {
            bool connected = false;
            Guid connectedViaDevice = Guid.Empty;
            string broadLinkSsid = "BroadlinkProv";

            foreach (NetworkIdentifier ssid in NativeWifi.EnumerateConnectedNetworkSsids())
            {
                if (ssid.ToString().Equals(broadLinkSsid))
                {
                    CommitLog(2, "Already connected to Broadlink Device AP");
                    connected = true;
                }
                
            }

            if (!connected)
            {
                CommitLog(2, "Scanning for Wireless Networks");
                await NativeWifi.ScanNetworksAsync(timeout: TimeSpan.FromSeconds(10));

                AvailableNetworkPack broadlinkAP = NativeWifi.EnumerateAvailableNetworks().Where(w => w.Ssid.ToString().Equals(broadLinkSsid)).First();
                if (broadlinkAP != null)
                {
                    CommitLog(2, "Found Broadlink Device AP");
                    NativeWifi.SetProfile(broadlinkAP.Interface.Id, ProfileType.PerUser, Network.WirelessProfile_Open(broadLinkSsid, "", Network.WirelessProfileType.Open), "", true);
                    bool result = await NativeWifi.ConnectNetworkAsync(broadlinkAP.Interface.Id, broadLinkSsid, broadlinkAP.BssType, new TimeSpan(0, 0, 15));
                    connectedViaDevice = broadlinkAP.Interface.Id;
                    connected = result;
                } else
                {
                    CommitLog(2, "Could not find Broadlink Device AP");
                }
            }

            IEnumerable<NetworkIdentifier> ssids = NativeWifi.EnumerateAvailableNetworkSsids();
            string[] ssiddrop = ssids.Select(x => x.ToString()).Distinct().Where(x => !String.IsNullOrEmpty(x)).ToArray();

            if (connected)
            {
                CommitLog(2, "Connected to device; collect wifi details");
                
                if (wd.ShowDialog(ssiddrop) == DialogResult.OK)
                {
                    bool success = await SharpBroadlink.Broadlink.Setup(wd.SSID, wd.Password, wd.Security);
                    if (!success)
                    {
                        MessageBox.Show("Could not connect to network");
                    }
                } else
                {
                    CommitLog(2, "Cancelled adding device to network");
                    if (connectedViaDevice != Guid.Empty)
                    {
                        await NativeWifi.DisconnectNetworkAsync(connectedViaDevice, new TimeSpan(0,0,5));
                    }
                }
            }
            else
            {
                CommitLog(2, "Could not find a Broadlink AP");
                MessageBox.Show("Could not find a Broadlink device.\nMake sure you have set it up for inclusion into the Network.", "Add to Network");
            }
            
        }

        private void ScanMenu_Click(object sender, EventArgs e)
        {
            ScanForDevices().GetAwaiter();
        }

        IDevice[] devs;

        private async Task<bool> ScanForDevices()
        {
            CommitLog(3, "Scanning for Devices...");
            this.devs = await Broadlink.Discover(2).WaitAsync(new TimeSpan(0, 0, 20));
            Devices.Items.Clear();
            if (devs.Length > 0)
            {
                CommitLog(3, devs.Length + " Devices Have been found");

                foreach (IDevice dev in devs)
                {
                    ListViewItem item = Devices.Items.Add(dev.Host.Address.ToString());
                    item.SubItems.Add(dev.DeviceType.ToString());
                    item.SubItems.Add(BitConverter.ToString(dev.Mac).Replace("-",":"));
                    item.SubItems.Add(dev.DevType.ToString("X"));
                    
                }
            }
            else
            {
                CommitLog(3, "No devices found!");
            }

            return true;
        }


        private void CodeConverterMenu_Click(object sender, EventArgs e)
        {
            using (Converter converter = new Converter())
            {
                converter.ShowDialog();
            }
        }

        private void CommitLog(int type, string message)
        {
            Log.AppendText(message + "\n");
            Log.ScrollToCaret();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ScanForDevices().GetAwaiter();
        }

        private void Devices_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Devices.SelectedIndices.Count == 1)
                {
                    DeviceContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void Devices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewHitTestInfo info = Devices.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;

                if (item != null)
                {
                    Learning learn = new Learning(devs.Where(w => w.Host.Address.ToString() == item.Text).First());
                    learn.ShowDialog();
                }

            }
        }
    }
}
