using EduMap.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduMap.Contollers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public  ActionResult Index()
        {
            return View();
        }
    }
}
