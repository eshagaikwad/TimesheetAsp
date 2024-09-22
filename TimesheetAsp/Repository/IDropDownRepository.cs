using TimesheetAsp.Model;

namespace TimesheetAsp.Repository
{
    public interface IDropDownRepository
    {
        public void SetProject(Project project);
        public void SetSubProject(SubProject subProject);
        public void SetBatch(Batch batch);

        public IEnumerable<Project> GetAllProject();
        public IEnumerable<SubProject> GetAllSubProject();
        public IEnumerable<Batch> GetAllBatch();
    }
}
