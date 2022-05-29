using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Broadlink_Controller.Conversion.CodeConverters
{
    public class LircConverter : ICodeConverter
    {
        public string Title => "LIRC Raw";

        public byte[] From(string data)
        {
            string[] dataSplit = data.Split(",");
            List<int> lirc = new List<int>(); 
            foreach (string segment in dataSplit)
            {
                lirc.Add(Convert.ToInt32(segment.Trim()));
            }
  
            List<byte> code = new List<byte>();
            //Convert Lirc to Broadlink
            for (int i = 0; i < lirc.Count; i++)
            {
                lirc[i] = lirc[i] * 269 / 8192;

                if (lirc[i] < 256)
                {
                    code.Add(Convert.ToByte(lirc[i]));
                }
                else
                {
                    code.Add(0x00); //Next number is two bytes
                    //var x = BitConverter.IsLittleEndian;
                    if (BitConverter.IsLittleEndian) //Values are in big endian
                    {
                        code.Add((byte)(BinaryPrimitives.ReverseEndianness(lirc[i]) >> 16));
                         code.Add((byte)(BinaryPrimitives.ReverseEndianness(lirc[i]) >> 24));
                    }
                    else
                    {
                        code.Add((byte)lirc[i]);
                        code.Add((byte)(lirc[i] >> 8));
                    }
                }

            }

            List<byte> broadlink = new List<byte>() { 0x26, 0x00 };
            if (BitConverter.IsLittleEndian) //size is in little endian
            {
                broadlink.Add((byte)code.Count);
                broadlink.Add((byte)(code.Count >> 8));
            }
            else
            {
                broadlink.Add((byte)BinaryPrimitives.ReverseEndianness(code.Count));
                broadlink.Add((byte)(BinaryPrimitives.ReverseEndianness(code.Count) >> 8));
            }
            broadlink.AddRange(code);
            broadlink.AddRange(new byte[] { 0x0d, 0x05 });

            return broadlink.ToArray();
        }

        public string To(byte[] data)
        {
            int size;
            if (BitConverter.IsLittleEndian)
            {
                size = BitConverter.ToInt16(data, 2);
            }
            else
            {
                size = BinaryPrimitives.ReverseEndianness(BitConverter.ToInt16(data, 2));
            }
            //Convert to LIRC
            byte[] payload = new byte[size];
            Array.Copy(data, 4, payload, 0, size);

            List<int> lirc = new List<int>();

            for (int i = 0; i < payload.Length; i++)
            {
                int code = Convert.ToInt32(payload[i]);
                if (code == 0x00)
                {
                    if (BitConverter.IsLittleEndian)
                    {
                        code = BinaryPrimitives.ReverseEndianness(BitConverter.ToInt16(payload, i + 1));
                        i += 2;
                    }
                    else
                    {
                        code = BitConverter.ToInt16(payload, i + 1);
                        i += 2;
                    }
                }

                code = (int)Math.Round((decimal)code / 269 * 8192);
                lirc.Add(code);
            }
            
            return String.Join(", ", lirc);
        }
    }
}
