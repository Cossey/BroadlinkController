namespace Broadlink_Controller
{
    partial class WirelessDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SSIDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SecurityLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SecurityDropdown = new System.Windows.Forms.ComboBox();
            this.SSIDBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SSIDLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SecurityLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SecurityDropdown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SSIDBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SSIDLabel
            // 
            this.SSIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SSIDLabel.AutoSize = true;
            this.SSIDLabel.Location = new System.Drawing.Point(3, 68);
            this.SSIDLabel.Name = "SSIDLabel";
            this.SSIDLabel.Size = new System.Drawing.Size(40, 20);
            this.SSIDLabel.TabIndex = 0;
            this.SSIDLabel.Text = "SSID";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 101);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Location = new System.Drawing.Point(3, 135);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(61, 20);
            this.SecurityLabel.TabIndex = 2;
            this.SecurityLabel.Text = "Security";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordBox.Location = new System.Drawing.Point(79, 98);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(249, 27);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // SecurityDropdown
            // 
            this.SecurityDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecurityDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityDropdown.FormattingEnabled = true;
            this.SecurityDropdown.Items.AddRange(new object[] {
            "None",
            "WEP",
            "WPA1",
            "WPA2",
            "WPA1/WPA2"});
            this.SecurityDropdown.Location = new System.Drawing.Point(79, 131);
            this.SecurityDropdown.Name = "SecurityDropdown";
            this.SecurityDropdown.Size = new System.Drawing.Size(249, 28);
            this.SecurityDropdown.TabIndex = 4;
            // 
            // SSIDBox
            // 
            this.SSIDBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSIDBox.FormattingEnabled = true;
            this.SSIDBox.Location = new System.Drawing.Point(79, 64);
            this.SSIDBox.Name = "SSIDBox";
            this.SSIDBox.Size = new System.Drawing.Size(249, 28);
            this.SSIDBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ConnectButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CancelButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(131, 162);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // ConnectButton
            // 
            this.ConnectButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConnectButton.Location = new System.Drawing.Point(3, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(94, 29);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "C&onnect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(103, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the details of the access point for the Broadlink Device to connect to:";
            // 
            // WirelessDetails
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WirelessDetails";
            this.Text = "Add to Network";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SSIDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SecurityLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.ComboBox SecurityDropdown;
        private System.Windows.Forms.ComboBox SSIDBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
    }
}