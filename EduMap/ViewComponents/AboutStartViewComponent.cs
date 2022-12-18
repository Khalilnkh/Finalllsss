using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class AboutStartViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public AboutStartViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AboutStart aboutStarts = await _context.AboutStarts.FirstOrDefaultAsync(s => s.IsDeleted == false);
            return View(await Task.FromResult(aboutStarts));
        }

    }
}
