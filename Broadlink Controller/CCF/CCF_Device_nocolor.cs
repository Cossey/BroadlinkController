using System;

namespace Broadlink_Controller.CCF
{
    public class CCF_Device_nocolor
    {
        public string Name { get; set; }
        public int NextDevice { get; set; }
        public CCF_Device_nocolor(byte[] bytes, int index)
        {
            NextDevice = BitConverter.ToInt32(bytes, index);
            int nameLocation = BitConverter.ToInt32(bytes, index + 4);
            int nameLength = bytes[nameLocation];
            Name = BitConverter.ToString(bytes, nameLocation + 1, nameLength);
        }
    }
}
