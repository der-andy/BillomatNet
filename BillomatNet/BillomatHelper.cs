﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BillomatNet
{
    /// <summary>
    /// Miscellaneous functions
    /// </summary>
    internal static class BillomatHelper
    {
        /// <summary>
        /// Converts the data in the specified stream to a Base64 encoded string
        /// </summary>
        /// <param name="file">The file stream</param>
        public static string Base64File(Stream file)
        {
            byte[] bytes;

            using (var ms = new MemoryStream())
            {
                int bytesRead;

                do
                {
                    var buf = new byte[32768];
                    bytesRead = file.Read(buf, 0, buf.Length);
                    ms.Write(buf, 0, bytesRead);
                } while (bytesRead > 0);

                bytes = ms.ToArray();
            }

            return Convert.ToBase64String(bytes);
        }
    }
}
