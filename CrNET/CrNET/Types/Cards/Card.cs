using CrNET.Types.Default;
using Newtonsoft.Json;

namespace CrNET.Types.Cards
{
    public class Card
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; }
        [JsonProperty("iconUrls")]
        public IconUrls IconUrls { get; set; }
    }
}
