using TimesheetAsp.Model;

namespace TimesheetAsp.Repository
{
    public interface ITimesheetRepository
    {
        IEnumerable<Timesheet> GetTimesheets();
        Timesheet GetTimesheetById(int id);
        void AddTimesheet(Timesheet timesheet);
        void UpdateTimesheet(Timesheet timesheet);
        void DeleteTimesheet(int id);
    }
}
