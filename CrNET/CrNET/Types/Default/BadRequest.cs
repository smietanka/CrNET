using Newtonsoft.Json;

namespace CrNET.Types.Default
{
    public class BadRequest
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
