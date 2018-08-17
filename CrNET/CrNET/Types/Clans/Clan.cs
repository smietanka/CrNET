using CrNET.Types.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrNET.Types.Clans
{
    public class Clan
    {
        public string tag { get; set; }
        public string name { get; set; }
        public int badgeId { get; set; }
        public string type { get; set; }
        public int clanScore { get; set; }
        public int requiredTrophies { get; set; }
        public int donationsPerWeek { get; set; }
        public int clanChestLevel { get; set; }
        public int clanChestMaxLevel { get; set; }
        public int members { get; set; }
        public Location location { get; set; }
    }
}
