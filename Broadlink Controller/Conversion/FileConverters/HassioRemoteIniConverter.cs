using IniParser.Model;
using IniParser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Broadlink_Controller.Conversion.FileConverters
{
    public class HassioRemoteIniConverter : IFileConverter
    {
        public HassioRemoteIniConverter() { }
        public string Title => "HassIO Remote INI";

        public string FileFormats => "HassIO Remove|*.ini";

        public Dictionary<string, byte[]> Import(byte[] data)
        {
            string stringData = Encoding.UTF8.GetString(data);
            Dictionary<string, byte[]> items = new Dictionary<string, byte[]>();
            IniDataParser parser = new IniDataParser();
            IniData model = parser.Parse(stringData);

            foreach (SectionData section in model.Sections)
            {
                foreach (KeyData key in section.Keys)
                {
                    byte[] raw = Convert.FromBase64String(key.Value);
                    items.Add(string.Concat(section.SectionName, "_", key.KeyName), raw);
                }
            }

            return items;
        }

        public byte[] Export(Dictionary<string, byte[]> data)
        {
            IniData model = new IniData();

            foreach (KeyValuePair<string, byte[]> code in data)
            {
                string section;
                string newkey;
                if (code.Key.Contains('_'))
                {
                    string[] sectionkey = code.Key.Split('_', 2);
                    section = sectionkey[0];
                    newkey = sectionkey[1];
                }
                else
                {
                    section = "code";
                    newkey = code.Key;
                }

                if (!model.Sections.ContainsSection(section))
                {
                    model.Sections.AddSection(section);
                }
                model.Sections.GetSectionData(section).Keys.AddKey(newkey, Convert.ToBase64String(code.Value));
            }

            return Encoding.UTF8.GetBytes(model.ToString());            
        }
    }
}
