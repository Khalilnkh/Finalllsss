using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class CourseHomeViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseHomeViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<CourseHome> courseHomes = await _context.CourseHomes.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(courseHomes));
        }
    }
}
