using Broadlink_Controller.Conversion;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Broadlink_Controller
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();

            LoadConversionDropdowns();
        }

        private void LoadConversionDropdowns()
        {
            IEnumerable<Type> converterList = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(t => t.GetTypes())
                       .Where(t => t.IsClass && t.Namespace == "Broadlink_Controller.Conversion.CodeConverters");

            List<ICodeConverter> convList = new List<ICodeConverter>();
            List<Type> names = converterList.ToList();
            names.ForEach(name =>
            {
                //try
                //{
                    ICodeConverter conversion = (ICodeConverter)AppDomain.CurrentDomain.GetAssemblies()[1].CreateInstance(name.FullName);
                    convList.Add(conversion);
                //}
                //catch { }
            });

            ConvertFrom.ComboBox.DataSource = convList.ToList();
            ConvertTo.ComboBox.DataSource = convList.ToList();

            ConvertFrom.ComboBox.DisplayMember = "Title";
            ConvertTo.ComboBox.DisplayMember = "Title";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Name)
            {
                case "ConvertButton":
                    try
                    {
                        byte[] from = ((ICodeConverter)ConvertFrom.SelectedItem).From(Input.Text);
                        Output.Text = ((ICodeConverter)ConvertTo.SelectedItem).To(from);
                    }
                    catch
                    {
                        MessageBox.Show("Conversion Error");
                    }
                    break;

            }
        }
    }
}
