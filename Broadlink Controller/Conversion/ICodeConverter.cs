using System;
using System.Collections.Generic;
using System.Text;

namespace Broadlink_Controller.Conversion
{
    public interface ICodeConverter
    {
        public byte[] From(string data);
        public string To(byte[] data);

        public string Title { get; }
    }
}
