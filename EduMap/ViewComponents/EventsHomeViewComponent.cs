using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class EventsHomeViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public EventsHomeViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<EventsHome> eventsHomes = await _context.EventsHomes.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(eventsHomes));
        }

    }
}
