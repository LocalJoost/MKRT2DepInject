using Newtonsoft.Json;

namespace Json
{
    public class DemoData
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}