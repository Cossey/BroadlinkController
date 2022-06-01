namespace Broadlink_Controller
{
    partial class Learning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learning));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LearnButton = new System.Windows.Forms.ToolStripSplitButton();
            this.LearnKeypadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LearnHeatpumpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LearnDirectionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelLearnButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RenameButton = new System.Windows.Forms.ToolStripButton();
            this.SendCommandButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeviceType = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeviceIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.Codes = new System.Windows.Forms.ListView();
            this.CommandName = new System.Windows.Forms.ColumnHeader();
            this.CommandCode = new System.Windows.Forms.ColumnHeader();
            this.LearnList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LearnButton,
            this.CancelLearnButton,
            this.toolStripSeparator1,
            this.ExportButton,
            this.ClearButton,
            this.DeleteButton,
            this.RenameButton,
            this.SendCommandButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LearnButton
            // 
            this.LearnButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LearnKeypadMenu,
            this.LearnHeatpumpMenu,
            this.LearnDirectionsMenu});
            this.LearnButton.Image = ((System.Drawing.Image)(resources.GetObject("LearnButton.Image")));
            this.LearnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LearnButton.Name = "LearnButton";
            this.LearnButton.Size = new System.Drawing.Size(84, 24);
            this.LearnButton.Text = "Learn";
            this.LearnButton.ButtonClick += new System.EventHandler(this.LearnButton_ButtonClick);
            // 
            // LearnKeypadMenu
            // 
            this.LearnKeypadMenu.Name = "LearnKeypadMenu";
            this.LearnKeypadMenu.Size = new System.Drawing.Size(220, 26);
            this.LearnKeypadMenu.Text = "Keypad";
            this.LearnKeypadMenu.Click += new System.EventHandler(this.LearnKeypadMenu_Click);
            // 
            // LearnHeatpumpMenu
            // 
            this.LearnHeatpumpMenu.Name = "LearnHeatpumpMenu";
            this.LearnHeatpumpMenu.Size = new System.Drawing.Size(220, 26);
            this.LearnHeatpumpMenu.Text = "Heat Pump";
            this.LearnHeatpumpMenu.Click += new System.EventHandler(this.LearnHeatpumpMenu_Click);
            // 
            // LearnDirectionsMenu
            // 
            this.LearnDirectionsMenu.Name = "LearnDirectionsMenu";
            this.LearnDirectionsMenu.Size = new System.Drawing.Size(220, 26);
            this.LearnDirectionsMenu.Text = "Directions/Ok/Back";
            this.LearnDirectionsMenu.Click += new System.EventHandler(this.LearnDirectionsMenu_Click);
            // 
            // CancelLearnButton
            // 
            this.CancelLearnButton.Enabled = false;
            this.CancelLearnButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelLearnButton.Image")));
            this.CancelLearnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelLearnButton.Name = "CancelLearnButton";
            this.CancelLearnButton.Size = new System.Drawing.Size(77, 24);
            this.CancelLearnButton.Text = "Cancel";
            this.CancelLearnButton.Click += new System.EventHandler(this.CancelLearnButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ExportButton
            // 
            this.ExportButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(76, 24);
            this.ExportButton.Text = "Export";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(67, 24);
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 24);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Image = ((System.Drawing.Image)(resources.GetObject("RenameButton.Image")));
            this.RenameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(87, 24);
            this.RenameButton.Text = "Rename";
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // SendCommandButton
            // 
            this.SendCommandButton.Image = ((System.Drawing.Image)(resources.GetObject("SendCommandButton.Image")));
            this.SendCommandButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendCommandButton.Name = "SendCommandButton";
            this.SendCommandButton.Size = new System.Drawing.Size(139, 24);
            this.SendCommandButton.Text = "Send Command";
            this.SendCommandButton.Click += new System.EventHandler(this.SendCommandButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage,
            this.DeviceType,
            this.DeviceIP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusMessage
            // 
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(872, 24);
            this.StatusMessage.Spring = true;
            this.StatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeviceType
            // 
            this.DeviceType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.Size = new System.Drawing.Size(75, 24);
            this.DeviceType.Text = "Type: TYP";
            // 
            // DeviceIP
            // 
            this.DeviceIP.Name = "DeviceIP";
            this.DeviceIP.Size = new System.Drawing.Size(69, 24);
            this.DeviceIP.Text = "IP: 0.0.0.0";
            // 
            // Codes
            // 
            this.Codes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CommandName,
            this.CommandCode});
            this.Codes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Codes.FullRowSelect = true;
            this.Codes.LabelEdit = true;
            this.Codes.Location = new System.Drawing.Point(0, 27);
            this.Codes.MultiSelect = false;
            this.Codes.Name = "Codes";
            this.Codes.Size = new System.Drawing.Size(1031, 387);
            this.Codes.TabIndex = 2;
            this.Codes.UseCompatibleStateImageBehavior = false;
            this.Codes.View = System.Windows.Forms.View.Details;
            this.Codes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codes_KeyDown);
            this.Codes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Codes_MouseDoubleClick);
            // 
            // CommandName
            // 
            this.CommandName.Text = "Name";
            this.CommandName.Width = 100;
            // 
            // CommandCode
            // 
            this.CommandCode.Text = "Code";
            this.CommandCode.Width = 700;
            // 
            // LearnList
            // 
            this.LearnList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LearnList.Name = "LearnList";
            this.LearnList.Size = new System.Drawing.Size(61, 4);
            // 
            // Learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 444);
            this.Controls.Add(this.Codes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Learning";
            this.Text = "Learn IR Codes";
            this.Load += new System.EventHandler(this.Learning_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel DeviceType;
        private System.Windows.Forms.ToolStripStatusLabel DeviceIP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ListView Codes;
        private System.Windows.Forms.ColumnHeader CommandName;
        private System.Windows.Forms.ColumnHeader CommandCode;
        private System.Windows.Forms.ContextMenuStrip LearnList;
        private System.Windows.Forms.ToolStripSplitButton LearnButton;
        private System.Windows.Forms.ToolStripMenuItem LearnKeypadMenu;
        private System.Windows.Forms.ToolStripMenuItem LearnHeatpumpMenu;
        private System.Windows.Forms.ToolStripButton SendCommandButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton CancelLearnButton;
        private System.Windows.Forms.ToolStripMenuItem LearnDirectionsMenu;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripButton RenameButton;
    }
}