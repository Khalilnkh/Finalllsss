using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class WhyChooseViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public WhyChooseViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<WhyChoose> whyChooses = await _context.WhyChooses.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(whyChooses));
        }
    }
}
