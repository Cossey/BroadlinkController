using SharpBroadlink.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadlink_Controller
{
    public partial class Learning : Form
    {

        private readonly Rm device;

        CancellationTokenSource learningCanceller;
        private bool isLearning = false;

        public Learning(IDevice device)
        {
            InitializeComponent();

            this.device = (Rm)device;

            learningCanceller = new();
            learningCanceller.Cancel();
        }

        private async void Learning_Load(object sender, EventArgs e)
        {
            DeviceType.Text = string.Format("Type: {0}", device.DeviceType.ToString());
            DeviceIP.Text = String.Format("IP: {0}", device.Host.Address.ToString());

            await device.Auth();
        }

        private async void Codes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewHitTestInfo info = Codes.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;

                if (item != null && !isLearning)
                {
                    StatusMessage.Text = String.Format("Sending remote code {0}...", item.Text);

                    await device.SendData(Convert.FromHexString(item.SubItems[1].Text));
                    StatusMessage.Text = "";
                }

            }
        }

        private void CancelLearnButton_Click(object sender, EventArgs e)
        {
            if (learningCanceller != null)
            {
                learningCanceller.Cancel();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all Learned Codes?", "Clear List", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Codes.Items.Clear();
                StatusMessage.Text = "Cleared all codes";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Codes.SelectedIndices.Count == 1)
            {
                Codes.Items.RemoveAt(Codes.SelectedIndices[0]);
            }
        }

        private async void SendCommandButton_Click(object sender, EventArgs e)
        {
            if (Codes.SelectedIndices.Count == 1)
            {
                StatusMessage.Text = String.Format("Sending remote code {0}...", Codes.Items[Codes.SelectedIndices[0]].Text);

                await device.SendData(Convert.FromHexString(Codes.Items[Codes.SelectedIndices[0]].SubItems[1].Text));
                StatusMessage.Text = "";
            }
        }

        private async void Codes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Codes.SelectedIndices.Count > 0)
            {
                switch (e.KeyData)
                {
                    case Keys.F2:
                        Codes.Items[Codes.SelectedIndices[0]].BeginEdit();
                        break;

                    case Keys.Delete:
                        Codes.Items.RemoveAt(Codes.SelectedIndices[0]);
                        break;

                    case Keys.Enter:
                        if (!isLearning)
                        {
                            StatusMessage.Text = String.Format("Sending remote code {0}...", Codes.Items[Codes.SelectedIndices[0]].Text);

                            await device.SendData(Convert.FromHexString(Codes.Items[Codes.SelectedIndices[0]].SubItems[1].Text));
                            StatusMessage.Text = "";
                        }
                        break;
                }
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (Codes.SelectedIndices.Count > 0)
            {
                Codes.Items[Codes.SelectedIndices[0]].BeginEdit();
            }
        }

        private async Task<bool> Learn(string key = "")
        {
            learningCanceller = new();
            try
            {
                StatusMessage.Text = key == "" ? "Learning..." : String.Format("Press key {0}...", key);
                byte[] data = await device.LearnIRCommnad(learningCanceller.Token);
                Codes.Items.Add(key).SubItems.Add(Convert.ToHexString(data));
                Codes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                StatusMessage.Text = key == "" ? "Received Code" : String.Format("Received Code for Key {0}", key);
                return false;
            }
            catch (OperationCanceledException)
            {
                StatusMessage.Text = "Learning cancelled";
                return true;
            }
        }

        private void IsLearning(bool learning = true)
        {
            isLearning = learning;
            LearnButton.Enabled = !learning;
            CancelLearnButton.Enabled = learning;
            SendCommandButton.Enabled = !learning;
        }

        private async void LearnButton_ButtonClick(object sender, EventArgs e)
        {
            IsLearning();
            await Learn();
            IsLearning(false);
        }

        private async Task LearnCodeList(string[] keys)
        {
            IsLearning();
            foreach (string key in keys)
            {
                bool cancelled = await Learn(key);
                if (cancelled) break;
            }
            IsLearning(false);
        }

        private async void LearnDirectionsMenu_Click(object sender, EventArgs e)
        {
            await LearnCodeList(new string[] { "Left", "Right", "Up", "Down", "Ok", "Back" });
        }

        private string[] GenNumbers(string prefix, int min, int max, int maxfan, bool tempFirst)
        {
            List<string> i = new();
            if (tempFirst)
            {
                for (int s = 0; s <= maxfan; s++)
                {
                    for (int j = min; j <= max; j++)
                    {
                        i.Add(String.Format("{0}_Speed{1}_Temp{2}", prefix, s, j));
                    }
                }
            }
            else
            {
                for (int j = min; j <= max; j++)
                {
                    for (int s = 0; s <= maxfan; s++)
                    {
                        i.Add(String.Format("{0}_Speed{1}_Temp{2}", prefix, s, j));
                    }
                }
            }

            return i.ToArray();
        }

        private async void LearnHeatpumpMenu_Click(object sender, EventArgs e)
        {
            List<string> i = new();
            HeatPump hp = new();
            if (hp.ShowDialog() == DialogResult.OK)
            {
                if (hp.FanMode.Checked)
                {
                    if (hp.FanNoTemp.Checked)
                    {
                        for (int s = 0; s <= (int)hp.MaxFanSpeed.Value; s++)
                        {
                            i.Add(String.Format("{0}_Speed{1}", "Fan", s));
                        }
                        if (hp.SwivelNonToggle.Checked)
                        {
                            for (int s = 0; s <= (int)hp.MaxFanSpeed.Value; s++)
                            {
                                i.Add(String.Format("{0}_Speed{1}", "Fan_Swing", s));
                            }

                        }
                    }
                    else
                    {
                        i.AddRange(GenNumbers("Fan", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                        if (hp.SwivelNonToggle.Checked)
                        {
                            i.AddRange(GenNumbers("Fan_Swing", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                        }
                    }
                }

                if (hp.AutoMode.Checked)
                {
                    i.AddRange(GenNumbers("Auto", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                    if (hp.SwivelNonToggle.Checked)
                    {
                        i.AddRange(GenNumbers("Auto_Swing", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                    }
                }

                if (hp.CoolMode.Checked)
                {
                    i.AddRange(GenNumbers("Cool", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                    if (hp.SwivelNonToggle.Checked)
                    {
                        i.AddRange(GenNumbers("Cool_Swing", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                    }
                }

                if (hp.DryMode.Checked)
                {
                    if (hp.DryNoFan.Checked)
                    {
                        for (int j = (int)hp.MinTemp.Value; j <= (int)hp.MaxTemp.Value; j++)
                        {
                            i.Add(String.Format("{0}_Temp{1}", "Dry", j));
                        }
                        if (hp.SwivelNonToggle.Checked)
                        {
                            for (int j = (int)hp.MinTemp.Value; j <= (int)hp.MaxTemp.Value; j++)
                            {
                                i.Add(String.Format("{0}_Temp{1}", "Dry_Swing", j));
                            }
                        }
                    }
                    else
                    {
                        i.AddRange(GenNumbers("Dry", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                        if (hp.SwivelNonToggle.Checked)
                        {
                            i.AddRange(GenNumbers("Dry_Swing", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                        }
                    }
                }

                if (hp.HeatMode.Checked)
                {
                    i.AddRange(GenNumbers("Heat", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                    if (hp.SwivelNonToggle.Checked)
                    {
                        i.AddRange(GenNumbers("Heat_Swing", (int)hp.MinTemp.Value, (int)hp.MaxTemp.Value, (int)hp.MaxFanSpeed.Value, hp.ByTemp.Checked));
                    }
                }

                await LearnCodeList(i.ToArray());
            }
        }

        private async void LearnKeypadMenu_Click(object sender, EventArgs e)
        {
            await LearnCodeList(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
        }

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.Filter = "openHAB Map File|*.map";
            sfd.Title = "Export File";
            sfd.AddExtension = true;
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new(sfd.FileName);
                switch (file.Extension)
                {
                    case ".map":
                        StringBuilder sb = new();
                        for (int i = 0; i < Codes.Items.Count; i++)
                        {
                            sb.AppendJoin("=", Codes.Items[i].Text.Replace("=", ""), Codes.Items[i].SubItems[1].Text);
                            sb.AppendLine();
                        }
                        await File.WriteAllTextAsync(file.FullName, sb.ToString());
                        break;
                }
            }
        }
    }
}
