using Newtonsoft.Json;

namespace Fanex.Letstalk.Service.Models
{
    public class JournalDetailModel
    {
        [JsonProperty(PropertyName = "old_value")]
        public string OldValue { get; set; }

        [JsonProperty(PropertyName = "new_value")]
        public string NewValue { get; set; }
    }
}