using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fanex.Letstalk.Service.Models
{
    public class JournalModel
    {
        [JsonProperty(PropertyName = "user")]
        public BaseModel User { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string  Notes { get; set; }

        [JsonProperty(PropertyName = "created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty(PropertyName = "details")]
        public List<JournalDetailModel> Details { get; set; }

    }
}