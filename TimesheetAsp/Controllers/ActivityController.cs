using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimesheetAsp.Model;
using TimesheetAsp.Services;

namespace TimesheetAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
            
        }
        [HttpPut("{id}")]
        public IActionResult UpdateTimesheet(int id, [FromBody] Activity activity)
        {
            if (id != activity.Id)
                return BadRequest();

            try
            {
                _activityService.UpdateActivity(activity);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                // Log exception
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTimesheet(int id)
        {
            _activityService.DeleteActivity(id);
            return NoContent();
        }
    }
}
