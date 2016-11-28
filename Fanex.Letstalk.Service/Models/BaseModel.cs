using Newtonsoft.Json;

namespace Fanex.Letstalk.Service.Models
{
    public class BaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}