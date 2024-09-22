using TimesheetAsp.Data;
using TimesheetAsp.Model;

namespace TimesheetAsp.Repository
{
    public class ActivityRepository:IActivityRepository
    {
        private readonly ApplicationDbContext _context;
        public ActivityRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            
        }

        public void UpdateActivity(Activity activity)
        {
            var existingActivity = _context.Activities.Find(activity.Id);
            if (existingActivity == null)
            {
                throw new KeyNotFoundException($"Activity with ID {activity.Id} not found.");
            }

           
            existingActivity.Project = activity.Project;
            existingActivity.SubProject = activity.SubProject;
            existingActivity.Hours = activity.Hours;
            existingActivity.Minutes = activity.Minutes;
            existingActivity.Description = activity.Description;

            _context.SaveChanges();
        }
     
        

        void IActivityRepository.DeleteActivity(int id)
        {
            var activity = _context.Activities.Find(id);
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                _context.SaveChanges();
            }
        }
    }
}
