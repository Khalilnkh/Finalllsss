using EduMap.DAL;
using EduMap.Models;
using EduMap.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.Contollers
{
    namespace EduHome.Controllers
    {
        public class CourseController : Controller
        {
            private readonly AppDbContext _context;
            public CourseController(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            {
               CourseIndexVm courseIndexVm = new CourseIndexVm
                {
                    CourseHomes = await _context.CourseHomes.Include(c => c.CourseImage).Include(c => c.CourseName).Include(c => c.Description).ToListAsync(),




              };

                return View(courseIndexVm);
            }

            public async Task<IActionResult>  CourseDetail(int? id)
            {
                CourseHome courseHome = await _context.CourseHomes.Include(ci => ci.CourseImage).Include(ct => ct.CourseName).Include(cd => cd.Description).FirstOrDefaultAsync(c => c.Id == id);
                CourseDetailsVM details = new CourseDetailsVM()
                {
                    Image = courseHome.CourseImage,
                    Title = courseHome.CourseName,
                    Description = courseHome.Description,
                };

               return View(details);
            }
        }
    }

}
