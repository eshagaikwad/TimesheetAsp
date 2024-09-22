using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimesheetAsp.Model;
using TimesheetAsp.Services;

namespace TimesheetAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropDownController : ControllerBase
    {
        private readonly IDropDownService _dropDownService;
        public DropDownController(IDropDownService dropDownService)
        {
            _dropDownService = dropDownService;
            
        }
        [HttpPost("projects")]
        public IActionResult SetProject([FromBody] Project project)
        {
            if (project == null)
            {
                return BadRequest("Project is null.");
            }
            _dropDownService.SetProject(project);
            return Ok();
        }

      
        [HttpPost("subprojects")]
        public IActionResult SetSubProject([FromBody] SubProject subProject)
        {
            if (subProject == null)
            {
                return BadRequest("SubProject is null.");
            }
            _dropDownService.SetSubProject(subProject);
            return Ok();
        }

        [HttpPost("batches")]
        public IActionResult SetBatch([FromBody] Batch batch)
        {
            if (batch == null)
            {
                return BadRequest("Batch is null.");
            }
            _dropDownService.SetBatch(batch);
            return Ok();
        }

        
        [HttpGet("projects")]
        public IActionResult GetAllProjects()
        {
            var projects = _dropDownService.GetAllProject();
            return Ok(projects);
        }

    
        [HttpGet("subprojects")]
        public IActionResult GetAllSubProjects()
        {
            var subProjects = _dropDownService.GetAllSubProject();
            return Ok(subProjects);
        }

     
        [HttpGet("batches")]
        public IActionResult GetAllBatches()
        {
            var batches = _dropDownService.GetAllBatch();
            return Ok(batches);
        }
    }
}
