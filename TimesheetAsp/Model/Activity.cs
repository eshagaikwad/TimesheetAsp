using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace TimesheetAsp.Model
{
    public class Activity
    {
        public int Id { get; set; }
        public string Project { get; set; }
        public string SubProject { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Description { get; set; }
        public int TimesheetId { get; set; }

        [JsonIgnore]
        [ValidateNever]
        public Timesheet Timesheet { get; set; }
    }
}
