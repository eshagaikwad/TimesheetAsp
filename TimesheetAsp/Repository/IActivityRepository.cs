using TimesheetAsp.Model;

namespace TimesheetAsp.Repository
{
    public interface IActivityRepository
    {
        void UpdateActivity(Activity activity);
        void DeleteActivity(int id);
    }
}
