using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Broadlink_Controller.Device
{
    static class Protocol
    {
        public static byte[] BuildMessage(byte command, byte[] payload, int count, byte[] mac, byte[] deviceId, byte[] iv, byte[] key, int deviceType)
        {
            byte[] header = new byte[] { 0x5A, 0xA5, 0xAA, 0x55, 0x5A, 0xA5, 0xAA, 0x55 };

            //byte[] packet = new byte[53];
            byte[] packet = new byte[0x38]; //Helper.CreateSpecialByteArray(54);
            header.CopyTo(packet, 0);

            packet[0x24] = (byte)(deviceType & 0xFF);
            packet[0x25] = (byte)(deviceType >> 8);
            packet[0x26] = command;
            packet[0x28] = (byte)(count & 0xFF);
            packet[0x29] = (byte)(count >> 8);
            //MAC Address
            packet[0x2a] = mac[0];
            packet[0x2b] = mac[1];
            packet[0x2c] = mac[2];
            packet[0x2d] = mac[3];
            packet[0x2e] = mac[4];
            packet[0x2f] = mac[5];
            //Device ID
            packet[0x30] = deviceId[0];
            packet[0x31] = deviceId[1];
            packet[0x32] = deviceId[2];
            packet[0x33] = deviceId[3];

            int checksum = 0xBEAF;
            int i = 0;
            byte[] abyte0;

            int k = (abyte0 = payload).Length;

            for (int j = 0; j < k; j++)
            {
                byte b = abyte0[j];
                i = Convert.ToUInt16(b);
                checksum += i;
                checksum &= 0xFFFF;
            }

            packet[0x34] = (byte)(checksum & 0xFF);
            packet[0x35] = (byte)(checksum >> 8);

            //Encrypt packet
            byte[] data = Encrypt(key, iv, payload);

            checksum = 0xBEAF;
            byte[] abyte1;
            int i1 = (abyte1 = data).Length;
            for (int l = 0; l < i1; l++)
            {
                byte b = abyte1[l];
                i = Convert.ToUInt16(b);
                checksum += i;
                checksum &= 0xFFFF;
            }
            data[0x20] = (byte)(checksum & 0xFF);
            data[0x21] = (byte)(checksum >> 8);
            return data;
        }
        /*
        public static byte[] BuildDiscoveryPacket(String host, int port)
        {
            String[] localAddress = null;
            localAddress = host.ToString().Split(@"\.");
            int[] ipAddress = new int[4];
            for (int i = 0; i < 4; i++)
                ipAddress[i] = Convert.ToInt32(localAddress[i]);

            Calendar calendar = Calendar.getInstance();
            calendar.setFirstDayOfWeek(2);
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.Local;
            timeZoneInfo.GetUtcOffset()
            DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
            
            int timezone = dateTimeOffset.Offset.TotalMinutes / 0x36ee80;

            byte[] packet = new byte[48];
            if (timezone < 0)
            {
                packet[8] = (byte)((255 + timezone) - 1);
                packet[9] = 255;
                packet[10] = 255;
                packet[11] = 255;
            }
            else
            {
                packet[8] = 8;
                packet[9] = 0;
                packet[10] = 0;
                packet[11] = 0;
            }
            packet[12] = (byte)(calendar.get(1) & 0xff);
            packet[13] = (byte)(calendar.get(1) >> 8);
            packet[14] = (byte)calendar.get(12);
            packet[15] = (byte)calendar.get(11);
            packet[16] = (byte)(calendar.get(1) - 2000);
            packet[17] = (byte)(calendar.get(7) + 1);
            packet[18] = (byte)calendar.get(5);
            packet[19] = (byte)(calendar.get(2) + 1);
            packet[24] = (byte)ipAddress[0];
            packet[25] = (byte)ipAddress[1];
            packet[26] = (byte)ipAddress[2];
            packet[27] = (byte)ipAddress[3];
            packet[28] = (byte)(port & 0xff);
            packet[29] = (byte)(port >> 8);
            packet[38] = 6;
            int checksum = 0xBEAF;
            byte abyte0[];
            int k = (abyte0 = packet).length;
            for (int j = 0; j < k; j++)
            {
                byte b = abyte0[j];
                checksum += Byte.toUnsignedInt(b);
            }

            checksum &= 0xffff;
            packet[32] = (byte)(checksum & 0xff);
            packet[33] = (byte)(checksum >> 8);
            return packet;
        }
        */
        public static byte[] BuildAuthPayload()
        {
            byte[] payload = new byte[0x50];
            byte[] blank = new byte[] { 0x31, 0x31, 0x31, 0x31, 0x31, 0x31 };

            Array.Copy(blank, 0, payload, 0x04, 6);
            Array.Copy(blank, 0, payload, 0x0A, 6);
            Array.Copy(blank, 0, payload, 0x10, 3);
            payload[0x1E] = 0x01;
            payload[0x2D] = 0x01;

            payload[0x30] = (byte)'T';
            payload[0x31] = (byte)'e';
            payload[0x32] = (byte)'s';
            payload[0x33] = (byte)'t';
            payload[0x34] = (byte)' ';
            payload[0x35] = (byte)' ';
            payload[0x36] = (byte)'1';

            return payload;
        }

        const int MIN_RESPONSE_PACKET_LENGTH = 0x24;
        public static byte[] DecodePacket(byte[] packet, byte[] key, byte[] iv)
        {
            if (packet.Length < MIN_RESPONSE_PACKET_LENGTH)
            {
                throw new Exception("Packet size too short");
            }
            bool error = packet[0x22] != 0 || packet[0x23] != 0;
            if (error)
            {
                throw new Exception("Invalid device response");
            }

            byte[] response = new byte[32];
            Array.Copy(packet, 56, response, 0, 32);
            return Decrypt(key, iv, response);
        }

        public static byte[] GetDeviceID(byte[] response)
        {
            byte[] deviceId = new byte[4];
            Array.Copy(response, 0, deviceId, 0, 4);
            return deviceId;
        }

        public static byte[] GetDeviceKey(byte[] response)
        {
            byte[] deviceKey = new byte[16];
            Array.Copy(response, 4, deviceKey, 0, 16);
            return deviceKey;
        }

        private static byte[] Encrypt(byte[] key, byte[] iv, byte[] payload)
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.None;
                aes.IV = iv;

                using (ICryptoTransform crypt = aes.CreateEncryptor())
                {
                    byte[] cipher = crypt.TransformFinalBlock(payload, 0, payload.Length);
                    return cipher;
                }
            }
        }

        private static byte[] Decrypt(byte[] key, byte[] iv, byte[] payload)
        {
            using (AesManaged aes = new AesManaged())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.None;
                aes.IV = iv;

                using (ICryptoTransform crypt = aes.CreateDecryptor())
                {
                    byte[] cipher = crypt.TransformFinalBlock(payload, 0, payload.Length);
                    return cipher;
                }
            }
        }
    }
}
