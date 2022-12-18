using EduMap.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EduMap.Contollers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
