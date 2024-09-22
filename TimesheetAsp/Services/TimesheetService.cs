using TimesheetAsp.Model;
using TimesheetAsp.Repository;

namespace TimesheetAsp.Services
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ITimesheetRepository _timesheetRepository;

        public TimesheetService(ITimesheetRepository timesheetRepository)
        {
            _timesheetRepository = timesheetRepository;
        }

        public IEnumerable<Timesheet> GetAllTimesheets()
        {
            return _timesheetRepository.GetTimesheets();
        }

        public Timesheet GetTimesheet(int id)
        {
            return _timesheetRepository.GetTimesheetById(id);
        }

        public void AddTimesheet(Timesheet timesheet)
        {
            _timesheetRepository.AddTimesheet(timesheet);
        }

        public void UpdateTimesheet(Timesheet timesheet)
        {
            _timesheetRepository.UpdateTimesheet(timesheet);
        }

        public void DeleteTimesheet(int id)
        {
            _timesheetRepository.DeleteTimesheet(id);
        }

      
    }
}
