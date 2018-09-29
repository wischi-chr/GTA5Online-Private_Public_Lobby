using System.Collections.Generic;

namespace SoloPublicLobbyGTA5.Models
{
    public class MWhitelist
    {
        public List<string> Ips { get; set; }

        public MWhitelist()
        {
            Ips = new List<string>();
        }
    }
}
