using DatabaseFirst.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SampleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Tasks.ToListAsync());
        }

        [HttpGet("Queries")]
        public async Task<IActionResult> Querying()
        {
            return Ok(await _context.TasksForQuerying.FromSqlRaw(
                "select title as task_title, ball as task_ball from tasks;").ToListAsync());
        }

        [HttpGet("filters")]
        public async Task<IActionResult> FiltersTask()
        {
            return Ok(await _context.TasksForQuerying.FromSqlRaw(
                "select title as task_title, ball as task_ball from tasks where ball > 6;").ToListAsync());
        }
    }
}
