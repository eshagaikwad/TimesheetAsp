using Microsoft.EntityFrameworkCore;
using TimesheetAsp.Model;

namespace TimesheetAsp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SubProject> SubProjects { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

       
       
    }
}
