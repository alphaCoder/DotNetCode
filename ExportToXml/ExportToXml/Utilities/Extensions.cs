using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ExportToXml.Utilities
{
    public static class Extensions
    {
        public static byte[] ToUTF8Bytes(this string cultureStringMsg)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            int dataLen = encoding.GetByteCount(cultureStringMsg);
            byte[] utf8bytes = new byte[dataLen];
            Encoding.UTF8.GetBytes(cultureStringMsg, 0, cultureStringMsg.Length, utf8bytes, 0);

            return utf8bytes;
        }
    }
}