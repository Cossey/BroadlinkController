using System;
using System.Collections.Generic;
using System.Linq;

namespace Broadlink_Controller.Conversion.CodeConverters
{
    public class Base64Converter : ICodeConverter
    {
        public Base64Converter() { }

        public string Title => "Broadlink Base 64";

        public byte[] From(string data)
        {
            return Convert.FromBase64String(data);
        }

        public string To(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
    }
}
