using TimesheetAsp.Model;
using TimesheetAsp.Repository;

namespace TimesheetAsp.Services
{
    public class ActivityService:IActivityService
    {
        private readonly IActivityRepository _activityRepository;
        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
            
        }

        public void DeleteActivity(int id)
        {
            _activityRepository.DeleteActivity(id);
        }

        public void UpdateActivity(Activity activity)
        {
            _activityRepository.UpdateActivity(activity);
        }
    }
}
