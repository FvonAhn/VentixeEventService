using EventService.Data;
using Microsoft.AspNetCore.Mvc;
using EventService.Models;

namespace EventService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly EventDbContext _context;

        public EventsController(EventDbContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] Event ev)
        {
            _context.Events.Add(ev);
            await _context.SaveChangesAsync();
            return Ok(ev);
        }

        [HttpGet]
        public IActionResult GetAllEvents() 
        {
            return Ok(_context.Events.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetEventById(int id) 
        {
            var ev = _context.Events.Find(id);
            return ev == null ? NotFound() : Ok(ev);
        }

    }
}
