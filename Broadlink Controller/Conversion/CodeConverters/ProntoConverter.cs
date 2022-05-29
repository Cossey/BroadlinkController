using System;
using System.Buffers.Binary;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Broadlink_Controller.Conversion.CodeConverters
{
    public class ProntoConverter : ICodeConverter
    {
        public string Title => "Pronto";

        public byte[] From(string data)
        {
            //Convert to LIRC
            short[] prontoHex = Utils.HexToShort(data.Replace(" ", ""));

            if (prontoHex[0] != 0x0000)
            {
                throw new Exception("This is not a pronto code.");
            }

            int size = 4 + 2 * (prontoHex[2] + prontoHex[3]);
            if (prontoHex.Length != size)
            {
                throw new Exception("Pulse width mismatch.");
            }

            double freq = 1 / (prontoHex[1] * 0.241246);

            int[] lirc = new int[prontoHex.Length - 4];
            for (int i = 4; i < prontoHex.Length; i++)
            {
                lirc[i - 4] = Convert.ToInt32(Math.Round(prontoHex[i] / freq));
            }

            List<byte> code = new List<byte>();
            //Convert Lirc to Broadlink
            for (int i = 0; i < lirc.Length; i++)
            {
                lirc[i] = lirc[i] * 269 / 8192;

                if (lirc[i] < 256)
                {
                    code.Add(Convert.ToByte(lirc[i]));
                }
                else
                {
                    code.Add(0x00); //Next number is two bytes
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

            return "";
        }
    }
}
