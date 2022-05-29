using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Broadlink_Controller
{
    static class Helper
    {
        public static byte[] CreateSpecialByteArray(int length)
        {
            byte[] arr = new byte[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0x00;
            }
            return arr;
        }

        public static List<IPAddress[]> GetAllIP4BroadcastAddresses()
        {
            List<IPAddress[]> AllIps = new List<IPAddress[]>();

            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netif.OperationalStatus == OperationalStatus.Up)
                {

                    IPInterfaceProperties properties = netif.GetIPProperties();

                    foreach (UnicastIPAddressInformation unicast in properties.UnicastAddresses)
                    {
                        if (unicast.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !IPAddress.IsLoopback(unicast.Address)) {
                            var addressInt = BitConverter.ToInt32(unicast.Address.GetAddressBytes(), 0);
                            var maskInt = BitConverter.ToInt32(unicast.IPv4Mask.GetAddressBytes(), 0);
                            var broadcastInt = addressInt | ~maskInt;
                            var broadcast = new IPAddress(BitConverter.GetBytes(broadcastInt));


                            //unicast.IPv4Mask
                            AllIps.Add(new IPAddress[] { unicast.Address, broadcast });
                        }
                    }
                }
            }

            return AllIps;

        }

        public static List<IPAddress> GetIpAddress()
        {
            List<IPAddress> AllIps = new List<IPAddress>();

            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {

                IPInterfaceProperties properties = netif.GetIPProperties();

                foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                {
                    AllIps.Add(unicast.Address);
                    Console.WriteLine(unicast.Address);
                }
            }

            return AllIps;
        }


        public static IPAddress GetDefaultGateway()
        {
            IPAddress result = null;
            var cards = NetworkInterface.GetAllNetworkInterfaces().ToList();
            if (cards.Any())
            {
                foreach (var card in cards)
                {
                    var props = card.GetIPProperties();
                    if (props == null)
                        continue;

                    var gateways = props.GatewayAddresses;
                    if (!gateways.Any())
                        continue;

                    var gateway =
                        gateways.FirstOrDefault(g => g.Address.AddressFamily.ToString() == "InterNetwork");
                    if (gateway == null)
                        continue;

                    result = gateway.Address;
                    break;
                };
            }

            return result;
        }

    }
}
