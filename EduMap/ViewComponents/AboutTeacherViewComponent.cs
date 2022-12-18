using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class AboutTeacherViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public AboutTeacherViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<AboutTeacher> aboutTeachers = await _context.AboutTeachers.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(aboutTeachers));
        }
    }
}
