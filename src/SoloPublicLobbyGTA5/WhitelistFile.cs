using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace SoloPublicLobbyGTA5
{
    public class WhitelistFile
    {
        private readonly string whitelistFile;

        public WhitelistFile(string whitelistFile)
        {
            this.whitelistFile = whitelistFile;
        }

        public void Save(IEnumerable<IPAddress> addresses)
        {
            File.WriteAllLines(whitelistFile, addresses.Select(ip => ip.ToString()));
        }

        public IEnumerable<IPAddress> Load()
        {
            try
            {
                return File
                    .ReadAllLines(whitelistFile)
                    .Select(ParseIpOrNull)
                    .Where(ip => ip != null);
            }
            catch
            {
                return Enumerable.Empty<IPAddress>();
            }
        }

        private static IPAddress ParseIpOrNull(string ip)
        {
            if (IPAddress.TryParse(ip, out var ipDeserialized))
                return ipDeserialized;
            return null;
        }
    }
}
