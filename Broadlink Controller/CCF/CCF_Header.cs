using System;

namespace Broadlink_Controller.CCF
{
    public class CCF_Header
    {
        const long IDENT_1 = 0x40A55A405F434346;
        const int IDENT_2 = 0x43434600;
        long Ident1 { get; set; }
        int Ident2 { get; set; }

        int CRC1 { get; set; }
        int CRC2 { get; set; }
        public int Res1 { get; set; }
        public int Res2 { get; set; }
        public int Res3 { get; set; }
        public int Res4 { get; set; }

        public int Capability { get; set; }

        public int Attribs { get; set; }
        public DateTime Date { get; set; }

        public int FirstHome { get; set; }
        public int FirstDevice { get; set; }
        public int FirstMacro { get; set; }

        public int Attributes { get; set; }

        public int MacroPanel { get; set; }

        public CCF_Header(byte[] bytes)
        {
            Res1 = BitConverter.ToInt32(bytes, 0x04);
            Ident1 = BitConverter.ToInt32(bytes, 0x08);
            CRC1 = BitConverter.ToInt32(bytes, 0x10);
            //Date
            int year = BitConverter.ToInt16(bytes, 0x14);
            int month = bytes[0x16];
            int day = bytes[0x17];
            Res2 = bytes[0x18];
            int hour = bytes[0x19];
            int min = bytes[0x1A];
            int sec = bytes[0x1B];
            Date = new DateTime(year, month, day, hour, min, sec);
            Res3 = BitConverter.ToInt32(bytes, 0x1C);
            Ident2 = BitConverter.ToInt32(bytes, 0x20);
            Capability = BitConverter.ToInt32(bytes, 0x24);
            CRC2 = BitConverter.ToInt32(bytes, 0x28);
            Attribs = BitConverter.ToInt32(bytes, 0x2C);
            FirstHome = BitConverter.ToInt32(bytes, 0x30);
            FirstDevice = BitConverter.ToInt32(bytes, 0x34);
            FirstMacro = BitConverter.ToInt32(bytes, 0x38);
            Attributes = BitConverter.ToInt32(bytes, 0x3C);
            Res4 = BitConverter.ToInt32(bytes, 0x40);
            MacroPanel = BitConverter.ToInt32(bytes, 0x44);
        }

        public void Validate()
        {
            if ((Ident1 != IDENT_1) || (Ident2 != IDENT_2))
            {
                throw new Exception("Not a valid CCF File.");
            }
            if (CRC1 != CRC2)
            {
                throw new Exception("CRC32 Mismatch.");
            }
        }

    }
}
