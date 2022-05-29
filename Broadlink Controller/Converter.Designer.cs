namespace Broadlink_Controller
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ConvertFrom = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ConvertTo = new System.Windows.Forms.ToolStripComboBox();
            this.ConvertButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Input, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Output, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input.Location = new System.Drawing.Point(3, 3);
            this.Input.MaxLength = 2147483647;
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input.Size = new System.Drawing.Size(794, 206);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Location = new System.Drawing.Point(3, 215);
            this.Output.MaxLength = 2147483647;
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(794, 207);
            this.Output.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ConvertFrom,
            this.toolStripLabel2,
            this.ConvertTo,
            this.ConvertButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "Convert From";
            // 
            // ConvertFrom
            // 
            this.ConvertFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvertFrom.Name = "ConvertFrom";
            this.ConvertFrom.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel2.Text = "To";
            // 
            // ConvertTo
            // 
            this.ConvertTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvertTo.Name = "ConvertTo";
            this.ConvertTo.Size = new System.Drawing.Size(150, 25);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Image = ((System.Drawing.Image)(resources.GetObject("ConvertButton.Image")));
            this.ConvertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(69, 22);
            this.ConvertButton.Text = "Convert";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Converter";
            this.Text = "Code Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ConvertFrom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.ToolStripComboBox ConvertTo;
        private System.Windows.Forms.ToolStripButton ConvertButton;
    }
}