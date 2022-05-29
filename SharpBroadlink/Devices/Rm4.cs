using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpBroadlink.Devices
{
    /// <summary>
    /// Rm4 - Programmable Remote Controller
    /// </summary>
    public class Rm4 : Rm
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host"></param>
        /// <param name="mac"></param>
        /// <param name="devType"></param>
        public Rm4(IPEndPoint host, byte[] mac, int devType) : base(host, mac, devType)
        {
            DeviceType = DeviceType.Rm4;

            switch (devType)
            {
                case 0x5F36:
                case 0x6508:
                    DeviceType = DeviceType.Rm3;
                    break;
            }

            SixBytePreamble = true;
        }

        

        #endregion Constructors
    }
}
