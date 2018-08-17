using CrNET.Types.Default;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CrNET.Types.Cards
{
    public class Cards
    {
        [JsonProperty("items")]
        public List<Card> CardList { get; set; }
    }
}
