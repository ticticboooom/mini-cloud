using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.Packages.Identification
{
    public class IdGeneratorHelper
    {
        public static string GenerateId(string prefix, string rootId)
        {
            var result = prefix + "-";
            var toEncode = rootId + "&" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(toEncode));
            result += encoded;
            return result;
        }
    }
}
