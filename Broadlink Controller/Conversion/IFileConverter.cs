using System;
using System.Collections.Generic;
using System.Text;

namespace Broadlink_Controller.Conversion
{
    public interface IFileConverter
    {
        public Dictionary<string, byte[]> Import(byte[] data);
        public byte[] Export(Dictionary<string, byte[]> data);

        public string Title { get; }
        public string FileFormats { get; }
    }
}
