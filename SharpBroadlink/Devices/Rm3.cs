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
    /// Rm3
    /// </summary>
    public class Rm3 : Rm
    {
 
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host"></param>
        /// <param name="mac"></param>
        /// <param name="devType"></param>
        public Rm3(IPEndPoint host, byte[] mac, int devType) : base(host, mac, devType)
        {
            DeviceType = DeviceType.Rm3;
        }

        #endregion Constructors


    }
}
