using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Fanex.Letstalk.Service.Models
{
    public class IssueModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "project")]
        public BaseModel Project { get; set; }

        [JsonProperty(PropertyName = "tracker")]
        public BaseModel Tracker { get; set; }

        [JsonProperty(PropertyName = "status")]
        public BaseModel Status { get; set; }

        [JsonProperty(PropertyName = "priority")]
        public BaseModel Priority { get; set; }

        [JsonProperty(PropertyName = "author")]
        public BaseModel Author { get; set; }

        [JsonProperty(PropertyName = "assigned_to")]
        public BaseModel Assignee { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "due_date")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "journals")]
        public List<JournalModel> Journals { get; set; }
    }
}