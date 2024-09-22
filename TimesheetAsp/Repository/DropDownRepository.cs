using TimesheetAsp.Data;
using TimesheetAsp.Model;

namespace TimesheetAsp.Repository
{
    public class DropDownRepository:IDropDownRepository
    {
        private readonly ApplicationDbContext _context;
        public DropDownRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            
        }
        public IEnumerable<Batch> GetAllBatch()
        {
            return _context.Batches;
        }

        public IEnumerable<Project> GetAllProject()
        {
            return _context.Projects;
        }

        public IEnumerable<SubProject> GetAllSubProject()
        {
            return _context.SubProjects;
        }

        public IEnumerable<Timesheet> GetAllTimesheet()
        {
            return _context.Timesheets;
        }
        public void SetProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void SetSubProject(SubProject subProject)
        {
            _context.SubProjects.Add(subProject);
            _context.SaveChanges();
        }

        public void SetBatch(Batch batch)
        {
            _context.Batches.Add(batch);
            _context.SaveChanges();
        }
    }
}
