using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestesAPIGuilherme.Base
{
    public static class Utils
    {
        public static string GetJsonToken(this string fileName, string token)
        {
            try
            {
                return JObject.Parse(File.ReadAllText(fileName)).Value<string>(token);
            }
            catch
            {
                return "";
            }
        }

        public static void Log(this string report, string message)
        {
            using (StreamWriter sw = new StreamWriter(report, true))
            {
                sw.WriteLine($"<h4>{message}</h4>");
            }
        }
    }
}
