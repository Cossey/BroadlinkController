using System;
using System.Collections.Generic;
using System.Text;

namespace Broadlink_Controller.Conversion.FileConverters
{

    public class OpenHabConverter : IFileConverter
    {
        public OpenHabConverter() { }
        public string Title => "openHAB map";

        public string FileFormats => "openHAB Map|*.map";

        public Dictionary<string, byte[]> Import(byte[] data)
        {
            string stringData = Encoding.UTF8.GetString(data);
            Dictionary<string, byte[]> items = new Dictionary<string, byte[]>();
            string[] lines = stringData.Split("\r\n");

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] kvp = line.Trim().Split('=', 2);
                items.Add(kvp[0], Utils.HexToByteArray(kvp[1]));
            }

            return items;
        }

        public byte[] Export(Dictionary<string, byte[]> data)
        {
            StringBuilder output = new StringBuilder();
            foreach (KeyValuePair<string, byte[]> code in data)
            {
                string hex = BitConverter.ToString(code.Value);
                output.AppendFormat("{0}={1}\r\n", code.Key, hex.Replace("-", ""));
            }
            return Encoding.UTF8.GetBytes(output.ToString());
        }
    }

}
