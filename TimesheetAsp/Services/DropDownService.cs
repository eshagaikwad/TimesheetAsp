using TimesheetAsp.Model;
using TimesheetAsp.Repository;

namespace TimesheetAsp.Services
{
    public class DropDownService:IDropDownService
    {
        private readonly IDropDownRepository _repository;
        public DropDownService(IDropDownRepository dropDownRepository)
        {
            _repository = dropDownRepository;  
        }

        public IEnumerable<Batch> GetAllBatch()
        {
            return _repository.GetAllBatch();
        }

        public IEnumerable<Project> GetAllProject()
        {
            return _repository.GetAllProject();
        }

        public IEnumerable<SubProject> GetAllSubProject()
        {
           return _repository.GetAllSubProject();
        }

        public void SetBatch(Batch batch)
        {
            _repository.SetBatch(batch);
        }

        public void SetProject(Project project)
        {
           _repository.SetProject(project);
        }

        public void SetSubProject(SubProject subProject)
        {
            _repository.SetSubProject(subProject);
        }
    }
}
