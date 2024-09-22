using Microsoft.EntityFrameworkCore;
using TimesheetAsp.Data;
using TimesheetAsp.Model;

namespace TimesheetAsp.Repository
{
    public class TimesheetRepository:ITimesheetRepository
    {
        private readonly ApplicationDbContext _context;
        public TimesheetRepository(ApplicationDbContext applicationDbContext) {
            _context = applicationDbContext;

        }

        public IEnumerable<Timesheet> GetTimesheets()
        {
            return _context.Timesheets.Include(t => t.Activities).ToList();
        }

        public Timesheet GetTimesheetById(int id)
        {
            return _context.Timesheets.Include(t => t.Activities).FirstOrDefault(t => t.Id == id);
        }

        public void AddTimesheet(Timesheet timesheet)
        {
            _context.Timesheets.Add(timesheet);
            _context.SaveChanges();
        }

        public void UpdateTimesheet(Timesheet timesheet)
        {
            _context.Timesheets.Update(timesheet);
            _context.SaveChanges();
        }

        public void DeleteTimesheet(int id)
        {
            var timesheet = _context.Timesheets.Find(id);
            if (timesheet != null)
            {
                _context.Timesheets.Remove(timesheet);
                _context.SaveChanges();
            }
        }
    }
}
