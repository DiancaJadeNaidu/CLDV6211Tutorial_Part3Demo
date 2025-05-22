using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Part3DemoCloudTut.Data;

namespace Part3DemoCloudTut.Controllers
{
    public class VenuesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VenuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? eventTypeId, bool? isAvailable, DateTime? startDate, DateTime? endDate)
        {
            var venues = _context.Venues.Include(v => v.EventType).AsQueryable();

            if (eventTypeId.HasValue)
                venues = venues.Where(v => v.EventTypeId == eventTypeId);

            if (isAvailable.HasValue)
                venues = venues.Where(v => v.IsAvailable == isAvailable);

            if (startDate.HasValue)
                venues = venues.Where(v => v.DateAvailable >= startDate);

            if (endDate.HasValue)
                venues = venues.Where(v => v.DateAvailable <= endDate);

            ViewData["EventTypes"] = await _context.EventTypes.ToListAsync();
            return View(await venues.ToListAsync());
        }
    }
}
