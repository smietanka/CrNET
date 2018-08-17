using Newtonsoft.Json;
using System.Collections.Generic;

namespace CrNET.Types.Clans
{
    public class Clans
    {
        [JsonProperty("items")]
        public List<Clan> ClanList { get; set; }
    }
}
