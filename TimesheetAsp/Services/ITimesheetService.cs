using TimesheetAsp.Model;

namespace TimesheetAsp.Services
{
    public interface ITimesheetService
    {
        public IEnumerable<Timesheet> GetAllTimesheets();
        public Timesheet GetTimesheet(int id);
        public void AddTimesheet(Timesheet timesheet);
        public void UpdateTimesheet(Timesheet timesheet);
        public void DeleteTimesheet(int id);
      
    }
}
