using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EduMap.ViewComponents

{
    public class FooterSliderViewComponent : ViewComponent
    {


        private readonly AppDbContext _context;
        public FooterSliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<FooterSlider> footerSliders = await _context.FooterSliders.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(footerSliders));
        }

    }
}
