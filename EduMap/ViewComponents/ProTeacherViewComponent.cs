using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class ProTeacherViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public ProTeacherViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<ProTeacher> proTeachers = await _context.ProTeachers.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(proTeachers));
        }

    }
}
