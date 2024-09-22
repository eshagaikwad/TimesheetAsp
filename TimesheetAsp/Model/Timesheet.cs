namespace TimesheetAsp.Model
{
    public class Timesheet
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string LeaveStatus { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
