using TimesheetAsp.Model;

namespace TimesheetAsp.Services
{
    public interface IDropDownService
    {
        public void SetProject(Project project);
        public void SetSubProject(SubProject subProject);
        public void SetBatch(Batch batch);

        public IEnumerable<Project> GetAllProject();
        public IEnumerable<SubProject> GetAllSubProject();
        public IEnumerable<Batch> GetAllBatch();
    }
}
