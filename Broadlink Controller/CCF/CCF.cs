using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Broadlink_Controller.CCF
{
    public class CCF
    {

        public static void LoadFile(string filePath)
        {
            byte[] fileData = File.ReadAllBytes(filePath);


            CCF_Header header = new CCF_Header(fileData);

        }
    }
}
