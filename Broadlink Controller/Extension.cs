using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Broadlink_Controller
{
    static class Extension
    {
        public static byte[] ToByteArray(this string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
