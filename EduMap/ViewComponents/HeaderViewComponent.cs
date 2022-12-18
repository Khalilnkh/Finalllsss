using EduMap.ComponentViewModels;
using EduMap.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(HeaderVM headerVMs)
        {
            

            return View(await Task.FromResult(headerVMs));


        }
    }
}
