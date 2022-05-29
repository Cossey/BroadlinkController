using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;


namespace Broadlink_Controller
{
    static class Network
    {
        private enum W32_ERROR_CODES
        {
            ERROR_SUCCESS = 0,
            NERR_Success = 0,
            ERROR_BAD_NET_NAME = 0x00000043,
            ERROR_BUFFTER_OVERFLOW = 0x0000006F,
            ERROR_GEN_FAILURE = 0x0000001F,
            ERROR_INVALID_PARAMETER = 0x00000057,
            ERROR_INVALID_USER_BUFFER = 0x000006F8,
            ERROR_NOT_FOUND = 0x00000490,
            ERROR_NOT_SUPPORTED = 0x00000032,
        }
        private static int INADDR_ANY = 0;

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        private static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        public static byte[] GetMACAddress(string ipAddress)
        {
            return GetMACAddress(IPAddress.Parse(ipAddress));
        }
        public static byte[] GetMACAddress(IPAddress ipAddress)
        {
            byte[] ab = new byte[6];
            int len = ab.Length, r = SendARP((int)ipAddress.Address, INADDR_ANY, ab, ref len);
            return ab;
        }

        public enum WirelessProfileType
        {
            Open = 0
        }

        public static string WirelessProfile_Open(string ssid, string password, WirelessProfileType type)
        {
            switch (type)
            {
                case WirelessProfileType.Open:
                    return string.Format(@"<?xml version=""1.0""?>
<WLANProfile xmlns=""http://www.microsoft.com/networking/WLAN/profile/v1"">
	<name>{0}</name>
	<SSIDConfig>
		<SSID>
			<hex>{1}</hex>
			<name>{0}</name>
		</SSID>
	</SSIDConfig>
	<connectionType>ESS</connectionType>
	<connectionMode>manual</connectionMode>
	<MSM>
		<security>
			<authEncryption>
				<authentication>open</authentication>
				<encryption>none</encryption>
				<useOneX>false</useOneX>
			</authEncryption>
		</security>
	</MSM>
</WLANProfile>", ssid, Convert.ToHexString(Encoding.UTF8.GetBytes(ssid)));
            }
            return "";
        }
    }
}
