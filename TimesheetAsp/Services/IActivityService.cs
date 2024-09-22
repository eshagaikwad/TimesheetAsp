using TimesheetAsp.Model;

namespace TimesheetAsp.Services
{
    public interface IActivityService
    {
        void UpdateActivity(Activity activity);
        void DeleteActivity(int id);
    }
}
