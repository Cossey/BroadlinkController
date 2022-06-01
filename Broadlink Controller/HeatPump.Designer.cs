namespace Broadlink_Controller
{
    partial class HeatPump
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatPump));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HeatMode = new System.Windows.Forms.CheckBox();
            this.CoolMode = new System.Windows.Forms.CheckBox();
            this.AutoMode = new System.Windows.Forms.CheckBox();
            this.FanMode = new System.Windows.Forms.CheckBox();
            this.DryMode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinTemp = new System.Windows.Forms.NumericUpDown();
            this.MaxTemp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ByTemp = new System.Windows.Forms.RadioButton();
            this.ByFan = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.SwivelNonToggle = new System.Windows.Forms.CheckBox();
            this.FanNoTemp = new System.Windows.Forms.CheckBox();
            this.DryNoFan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxFanSpeed = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTemp)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFanSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MaxFanSpeed, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.HeatMode);
            this.flowLayoutPanel1.Controls.Add(this.CoolMode);
            this.flowLayoutPanel1.Controls.Add(this.AutoMode);
            this.flowLayoutPanel1.Controls.Add(this.FanMode);
            this.flowLayoutPanel1.Controls.Add(this.DryMode);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(150, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // HeatMode
            // 
            this.HeatMode.AutoSize = true;
            this.HeatMode.Location = new System.Drawing.Point(3, 3);
            this.HeatMode.Name = "HeatMode";
            this.HeatMode.Size = new System.Drawing.Size(63, 24);
            this.HeatMode.TabIndex = 0;
            this.HeatMode.Text = "Heat";
            this.HeatMode.UseVisualStyleBackColor = true;
            // 
            // CoolMode
            // 
            this.CoolMode.AutoSize = true;
            this.CoolMode.Location = new System.Drawing.Point(72, 3);
            this.CoolMode.Name = "CoolMode";
            this.CoolMode.Size = new System.Drawing.Size(62, 24);
            this.CoolMode.TabIndex = 1;
            this.CoolMode.Text = "Cool";
            this.CoolMode.UseVisualStyleBackColor = true;
            // 
            // AutoMode
            // 
            this.AutoMode.AutoSize = true;
            this.AutoMode.Location = new System.Drawing.Point(140, 3);
            this.AutoMode.Name = "AutoMode";
            this.AutoMode.Size = new System.Drawing.Size(63, 24);
            this.AutoMode.TabIndex = 2;
            this.AutoMode.Text = "Auto";
            this.AutoMode.UseVisualStyleBackColor = true;
            // 
            // FanMode
            // 
            this.FanMode.AutoSize = true;
            this.FanMode.Location = new System.Drawing.Point(209, 3);
            this.FanMode.Name = "FanMode";
            this.FanMode.Size = new System.Drawing.Size(53, 24);
            this.FanMode.TabIndex = 3;
            this.FanMode.Text = "Fan";
            this.FanMode.UseVisualStyleBackColor = true;
            this.FanMode.CheckedChanged += new System.EventHandler(this.FanMode_CheckedChanged);
            // 
            // DryMode
            // 
            this.DryMode.AutoSize = true;
            this.DryMode.Location = new System.Drawing.Point(268, 3);
            this.DryMode.Name = "DryMode";
            this.DryMode.Size = new System.Drawing.Size(54, 24);
            this.DryMode.TabIndex = 4;
            this.DryMode.Text = "Dry";
            this.DryMode.UseVisualStyleBackColor = true;
            this.DryMode.CheckedChanged += new System.EventHandler(this.DryMode_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperature Range";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MinTemp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MaxTemp, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 33);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "to";
            // 
            // MinTemp
            // 
            this.MinTemp.Location = new System.Drawing.Point(3, 3);
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.Size = new System.Drawing.Size(60, 27);
            this.MinTemp.TabIndex = 1;
            // 
            // MaxTemp
            // 
            this.MaxTemp.Location = new System.Drawing.Point(98, 3);
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.Size = new System.Drawing.Size(60, 27);
            this.MaxTemp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fan Speed Levels";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Learn Order";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.ByTemp);
            this.flowLayoutPanel2.Controls.Add(this.ByFan);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(150, 101);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(264, 30);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // ByTemp
            // 
            this.ByTemp.AutoSize = true;
            this.ByTemp.Checked = true;
            this.ByTemp.Location = new System.Drawing.Point(3, 3);
            this.ByTemp.Name = "ByTemp";
            this.ByTemp.Size = new System.Drawing.Size(134, 24);
            this.ByTemp.TabIndex = 1;
            this.ByTemp.TabStop = true;
            this.ByTemp.Text = "by Temperature";
            this.toolTip1.SetToolTip(this.ByTemp, "Learn by Temperature\r\n\r\nLearns codes by the min to max temperature for each fan s" +
        "peed.");
            this.ByTemp.UseVisualStyleBackColor = true;
            // 
            // ByFan
            // 
            this.ByFan.AutoSize = true;
            this.ByFan.Location = new System.Drawing.Point(143, 3);
            this.ByFan.Name = "ByFan";
            this.ByFan.Size = new System.Drawing.Size(118, 24);
            this.ByFan.TabIndex = 0;
            this.ByFan.Text = "by Fan Speed";
            this.toolTip1.SetToolTip(this.ByFan, "Learn by Fan Speed\r\n\r\nLearns each code by the temperature then min and max fan sp" +
        "eed.");
            this.ByFan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.CancelButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.GoButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(458, 219);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel4.TabIndex = 8;
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
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GoButton.Location = new System.Drawing.Point(3, 3);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 29);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "&Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.SwivelNonToggle);
            this.flowLayoutPanel3.Controls.Add(this.FanNoTemp);
            this.flowLayoutPanel3.Controls.Add(this.DryNoFan);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(150, 131);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(447, 30);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // SwivelNonToggle
            // 
            this.SwivelNonToggle.AutoSize = true;
            this.SwivelNonToggle.Location = new System.Drawing.Point(3, 3);
            this.SwivelNonToggle.Name = "SwivelNonToggle";
            this.SwivelNonToggle.Size = new System.Drawing.Size(155, 24);
            this.SwivelNonToggle.TabIndex = 12;
            this.SwivelNonToggle.Text = "Non-Toggle Swing";
            this.toolTip1.SetToolTip(this.SwivelNonToggle, resources.GetString("SwivelNonToggle.ToolTip"));
            this.SwivelNonToggle.UseVisualStyleBackColor = true;
            // 
            // FanNoTemp
            // 
            this.FanNoTemp.AutoSize = true;
            this.FanNoTemp.Enabled = false;
            this.FanNoTemp.Location = new System.Drawing.Point(164, 3);
            this.FanNoTemp.Name = "FanNoTemp";
            this.FanNoTemp.Size = new System.Drawing.Size(121, 24);
            this.FanNoTemp.TabIndex = 1;
            this.FanNoTemp.Text = "Fan: No Temp";
            this.toolTip1.SetToolTip(this.FanNoTemp, "No Temperature on Fan Mode\r\n\r\nWhen the Fan Mode does not have a Temperature setti" +
        "ng.");
            this.FanNoTemp.UseVisualStyleBackColor = true;
            // 
            // DryNoFan
            // 
            this.DryNoFan.AutoSize = true;
            this.DryNoFan.Enabled = false;
            this.DryNoFan.Location = new System.Drawing.Point(291, 3);
            this.DryNoFan.Name = "DryNoFan";
            this.DryNoFan.Size = new System.Drawing.Size(153, 24);
            this.DryNoFan.TabIndex = 0;
            this.DryNoFan.Text = "Dry: No Fan Speed";
            this.toolTip1.SetToolTip(this.DryNoFan, "No Fan Speed for Dry Mode\r\n\r\nWhen Dry Mode does not have Fan Speed control.");
            this.DryNoFan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tweaks";
            // 
            // MaxFanSpeed
            // 
            this.MaxFanSpeed.Location = new System.Drawing.Point(153, 71);
            this.MaxFanSpeed.Name = "MaxFanSpeed";
            this.MaxFanSpeed.Size = new System.Drawing.Size(60, 27);
            this.MaxFanSpeed.TabIndex = 11;
            this.toolTip1.SetToolTip(this.MaxFanSpeed, "Fan Speed Levels\r\n\r\nIf your applicance supports auto, include that in the fan spe" +
        "ed counter (designate it as speed 0).");
            // 
            // HeatPump
            // 
            this.AcceptButton = this.GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeatPump";
            this.Text = "Heat Pump Learning Setup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTemp)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFanSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.CheckBox HeatMode;
        public System.Windows.Forms.CheckBox CoolMode;
        public System.Windows.Forms.CheckBox AutoMode;
        public System.Windows.Forms.CheckBox FanMode;
        public System.Windows.Forms.CheckBox DryMode;
        public System.Windows.Forms.NumericUpDown MinTemp;
        public System.Windows.Forms.NumericUpDown MaxTemp;
        public System.Windows.Forms.RadioButton ByFan;
        public System.Windows.Forms.RadioButton ByTemp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox DryNoFan;
        public System.Windows.Forms.CheckBox FanNoTemp;
        public System.Windows.Forms.NumericUpDown MaxFanSpeed;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox SwivelNonToggle;
    }
}