using Newtonsoft.Json;

namespace EmberSampleAPI
{
    public class Book
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("author")]
        public string Author { get; set; } = string.Empty;
        [JsonProperty("pages")]
        public int Pages { get; set; }
    }
}
