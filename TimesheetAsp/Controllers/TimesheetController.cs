using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimesheetAsp.Model;
using TimesheetAsp.Services;

namespace TimesheetAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        private readonly ITimesheetService _timesheetService;

        public TimesheetController(ITimesheetService timesheetService)
        {
            _timesheetService = timesheetService;
        }

        [HttpGet]
        public IActionResult GetTimesheets()
        {
            var timesheets = _timesheetService.GetAllTimesheets();
            return Ok(timesheets);
        }

        [HttpGet("{id}")]
        public IActionResult GetTimesheet(int id)
        {
            var timesheet = _timesheetService.GetTimesheet(id);
            if (timesheet == null)
                return NotFound();
            return Ok(timesheet);
        }

        [HttpPost]
        public IActionResult CreateTimesheet([FromBody] Timesheet timesheet)
        {
            _timesheetService.AddTimesheet(timesheet);
            return CreatedAtAction(nameof(GetTimesheet), new { id = timesheet.Id }, timesheet);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTimesheet(int id, [FromBody] Timesheet timesheet)
        {
            if (id != timesheet.Id)
                return BadRequest();

            _timesheetService.UpdateTimesheet(timesheet);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTimesheet(int id)
        {
            _timesheetService.DeleteTimesheet(id);
            return NoContent();
        }
    }
}
