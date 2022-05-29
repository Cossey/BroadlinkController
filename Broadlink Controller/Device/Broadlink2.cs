using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Transactions;

namespace Broadlink_Controller.Device
{
    public class Broadlink2
    {
        int count;
        bool authenticated = false;
        byte[] deviceId;
        byte[] deviceKey;

        const String INITIAL_DEVICE_ID = "00000000";
        const String BROADLINK_AUTH_KEY = "097628343fe99e23765c1513accf8b02";
        const String BROADLINK_IV = "562e17996d093d28ddb3ba695a2e6f58";

        //string macAddress;

        byte[] macAddress;

        Socket socket;
        IPEndPoint endPoint;

        public Broadlink2(string macAddress, string ipAddress)
        {
            count = new Random().Next(65535);

            this.macAddress = macAddress.Split(':', '-').Select(x => Convert.ToByte(x, 16)).ToArray();

            socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), 80);
            socket.Bind(new IPEndPoint(IPAddress.Parse("0.0.0.0"), 80));
        }

        private byte[] SendAndReceiveDatagram(byte[] data)
        {
            socket.SendTo(data, endPoint);
            byte[] incoming = new byte[1024];
            int length = socket.Receive(incoming);
            return incoming;
        }

        public bool Authenticate()
        {
            Debug.Print("Authenticating...");
            authenticated = false;

            deviceId = INITIAL_DEVICE_ID.ToByteArray();
            deviceKey = BROADLINK_AUTH_KEY.ToByteArray();

            byte[] authRequest = BuildMessage((byte)0x65, Protocol.BuildAuthPayload(), -1);
            byte[] response = SendAndReceiveDatagram(authRequest);
            byte[] decryptResponse = DecodeDevicePacket(response);
            deviceId = Protocol.GetDeviceID(decryptResponse);
            deviceKey = Protocol.GetDeviceKey(decryptResponse);

            authenticated = true;
            return authenticated;
        }

        private byte[] DecodeDevicePacket(byte[] response)
        {
            byte[] rxBytes = Protocol.DecodePacket(response, deviceKey, BROADLINK_IV.ToByteArray());
            return rxBytes;
        }

        private byte[] BuildMessage(byte command, byte[] payload, int deviceType)
        {
            count = count + 1 & 0xFFFF;
            return Protocol.BuildMessage(command, payload, count, macAddress, deviceId, BROADLINK_IV.ToByteArray(), deviceKey, deviceType);
        }
    }
}
