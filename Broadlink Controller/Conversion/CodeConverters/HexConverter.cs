using System.Collections.Generic;
using System.Linq;

namespace Broadlink_Controller.Conversion.CodeConverters
{
    public class HexConverter : ICodeConverter
    {
        public HexConverter() { }
        public string Title => "Broadlink Hexidecimal";
         
        public byte[] From(string data)
        {
            return Utils.HexToByteArray(data.Replace(" ", ""));
        }

        public string To(byte[] data)
        {
            return Utils.ByteArrayToHex(data);
        }
    }
}
