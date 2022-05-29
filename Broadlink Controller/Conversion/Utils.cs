using System;

namespace Broadlink_Controller.Conversion
{
    static class Utils
    {
        public static string ByteArrayToHex(byte[] bytes)
        {
            string hex = BitConverter.ToString(bytes);
            return hex.Replace("-", "");
        }

        public static short[] HexToShort(string hex)
        {
            int NumberChars = hex.Length;
            short[] ints = new short[NumberChars / 4];
            for (int i = 0; i < NumberChars; i += 4)
            {
                ints[i / 4] = Convert.ToInt16(hex.Substring(i, 4), 16);
            }
            return ints;
        }

        public static byte[] HexToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }
    }
}
