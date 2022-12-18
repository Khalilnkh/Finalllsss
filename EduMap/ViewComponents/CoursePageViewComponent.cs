using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EduMap.ViewComponents
{
    public class CoursePageViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CoursePageViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<CoursePage> coursePages = await _context.CoursePages.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(coursePages));
        }
    }
}
