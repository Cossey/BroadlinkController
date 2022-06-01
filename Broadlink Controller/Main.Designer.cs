namespace Broadlink_Controller
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DevicesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ScanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectConnectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddToNetworkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeConverterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.Devices = new System.Windows.Forms.ListView();
            this.IP = new System.Windows.Forms.ColumnHeader();
            this.Device = new System.Windows.Forms.ColumnHeader();
            this.MAC = new System.Windows.Forms.ColumnHeader();
            this.DeviceType = new System.Windows.Forms.ColumnHeader();
            this.DeviceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.learningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyIPAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMACAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.DeviceContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.DevicesMenu,
            this.ToolsMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadListMenu,
            this.SaveListMenu,
            this.toolStripSeparator3,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "&File";
            // 
            // LoadListMenu
            // 
            this.LoadListMenu.Image = ((System.Drawing.Image)(resources.GetObject("LoadListMenu.Image")));
            this.LoadListMenu.Name = "LoadListMenu";
            this.LoadListMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.LoadListMenu.Size = new System.Drawing.Size(253, 26);
            this.LoadListMenu.Text = "&Load Device List";
            // 
            // SaveListMenu
            // 
            this.SaveListMenu.Image = ((System.Drawing.Image)(resources.GetObject("SaveListMenu.Image")));
            this.SaveListMenu.Name = "SaveListMenu";
            this.SaveListMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveListMenu.Size = new System.Drawing.Size(253, 26);
            this.SaveListMenu.Text = "&Save Device List";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(250, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Image = ((System.Drawing.Image)(resources.GetObject("ExitMenu.Image")));
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMenu.Size = new System.Drawing.Size(253, 26);
            this.ExitMenu.Text = "E&xit";
            // 
            // DevicesMenu
            // 
            this.DevicesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScanMenu,
            this.DirectConnectMenu,
            this.toolStripSeparator1,
            this.AddToNetworkMenu});
            this.DevicesMenu.Name = "DevicesMenu";
            this.DevicesMenu.Size = new System.Drawing.Size(74, 24);
            this.DevicesMenu.Text = "Devices";
            // 
            // ScanMenu
            // 
            this.ScanMenu.Image = ((System.Drawing.Image)(resources.GetObject("ScanMenu.Image")));
            this.ScanMenu.Name = "ScanMenu";
            this.ScanMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.ScanMenu.Size = new System.Drawing.Size(224, 26);
            this.ScanMenu.Text = "&Refresh";
            // 
            // DirectConnectMenu
            // 
            this.DirectConnectMenu.Image = ((System.Drawing.Image)(resources.GetObject("DirectConnectMenu.Image")));
            this.DirectConnectMenu.Name = "DirectConnectMenu";
            this.DirectConnectMenu.Size = new System.Drawing.Size(224, 26);
            this.DirectConnectMenu.Text = "Direct &Connect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // AddToNetworkMenu
            // 
            this.AddToNetworkMenu.Image = ((System.Drawing.Image)(resources.GetObject("AddToNetworkMenu.Image")));
            this.AddToNetworkMenu.Name = "AddToNetworkMenu";
            this.AddToNetworkMenu.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.AddToNetworkMenu.Size = new System.Drawing.Size(224, 26);
            this.AddToNetworkMenu.Text = "Add To &Network";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CodeConverterMenu});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(58, 24);
            this.ToolsMenu.Text = "Tools";
            // 
            // CodeConverterMenu
            // 
            this.CodeConverterMenu.Image = ((System.Drawing.Image)(resources.GetObject("CodeConverterMenu.Image")));
            this.CodeConverterMenu.Name = "CodeConverterMenu";
            this.CodeConverterMenu.Size = new System.Drawing.Size(224, 26);
            this.CodeConverterMenu.Text = "Code Con&verter";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpHelpMenu,
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(55, 24);
            this.HelpMenu.Text = "&Help";
            // 
            // HelpHelpMenu
            // 
            this.HelpHelpMenu.Image = ((System.Drawing.Image)(resources.GetObject("HelpHelpMenu.Image")));
            this.HelpHelpMenu.Name = "HelpHelpMenu";
            this.HelpHelpMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpHelpMenu.Size = new System.Drawing.Size(224, 26);
            this.HelpHelpMenu.Text = "&Help";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Image = ((System.Drawing.Image)(resources.GetObject("AboutMenu.Image")));
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(224, 26);
            this.AboutMenu.Text = "A&bout";
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(0, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(150, 46);
            this.Log.TabIndex = 1;
            this.Log.Text = "";
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 30);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.Devices);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.Log);
            this.MainContainer.Panel2Collapsed = true;
            this.MainContainer.Size = new System.Drawing.Size(914, 570);
            this.MainContainer.SplitterDistance = 282;
            this.MainContainer.TabIndex = 2;
            // 
            // Devices
            // 
            this.Devices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.Device,
            this.MAC,
            this.DeviceType});
            this.Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Devices.FullRowSelect = true;
            this.Devices.Location = new System.Drawing.Point(0, 0);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(914, 570);
            this.Devices.TabIndex = 0;
            this.Devices.UseCompatibleStateImageBehavior = false;
            this.Devices.View = System.Windows.Forms.View.Details;
            this.Devices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Devices_MouseClick);
            this.Devices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Devices_MouseDoubleClick);
            // 
            // IP
            // 
            this.IP.Text = "IP Address";
            this.IP.Width = 150;
            // 
            // Device
            // 
            this.Device.Text = "Device";
            this.Device.Width = 160;
            // 
            // MAC
            // 
            this.MAC.Text = "MAC Address";
            this.MAC.Width = 200;
            // 
            // DeviceType
            // 
            this.DeviceType.Text = "ID";
            // 
            // DeviceContextMenu
            // 
            this.DeviceContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DeviceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learningToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem});
            this.DeviceContextMenu.Name = "contextMenuStrip1";
            this.DeviceContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.DeviceContextMenu.Size = new System.Drawing.Size(136, 58);
            // 
            // learningToolStripMenuItem
            // 
            this.learningToolStripMenuItem.Name = "learningToolStripMenuItem";
            this.learningToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.learningToolStripMenuItem.Text = "Learning";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyIPAddress,
            this.CopyMACAddress});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // CopyIPAddress
            // 
            this.CopyIPAddress.Name = "CopyIPAddress";
            this.CopyIPAddress.Size = new System.Drawing.Size(181, 26);
            this.CopyIPAddress.Text = "IP Address";
            // 
            // CopyMACAddress
            // 
            this.CopyMACAddress.Name = "CopyMACAddress";
            this.CopyMACAddress.Size = new System.Drawing.Size(181, 26);
            this.CopyMACAddress.Text = "MAC Address";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Broadlink Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.DeviceContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DevicesMenu;
        private System.Windows.Forms.ToolStripMenuItem DirectConnectMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem CodeConverterMenu;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.ListView Devices;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Device;
        private System.Windows.Forms.ColumnHeader MAC;
        private System.Windows.Forms.ToolStripMenuItem ScanMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddToNetworkMenu;
        private System.Windows.Forms.ContextMenuStrip DeviceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyIPAddress;
        private System.Windows.Forms.ToolStripMenuItem CopyMACAddress;
        private System.Windows.Forms.ColumnHeader DeviceType;
        private System.Windows.Forms.ToolStripMenuItem learningToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem HelpHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadListMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveListMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

