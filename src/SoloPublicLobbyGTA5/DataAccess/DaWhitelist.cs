using SoloPublicLobbyGTA5.Helpers;
using SoloPublicLobbyGTA5.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SoloPublicLobbyGTA5.DataAccess
{
    public class DaWhitelist
    {
        private static string path = AppDomain.CurrentDomain.BaseDirectory + "settings.json";

        public static List<IPAddress> ReadIPsFromJSON()
        {
            List<IPAddress> addresses = new List<IPAddress>();

            if(!File.Exists(path))
            {
                SaveToJson(new MWhitelist());
            }

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                MWhitelist whitelist = JsonConvert.DeserializeObject<MWhitelist>(json);

                //Todo: fix with linq
                foreach (string address in whitelist.Ips)
                {
                    if (IPAddress.TryParse(address, out var ip))
                        addresses.Add(ip);
                }
            }
            return addresses;
        }

        public static void SaveToJson(MWhitelist whitelist)
        {
            string json = JsonConvert.SerializeObject(whitelist);
            File.WriteAllText(path, json);
        }
    }
}
