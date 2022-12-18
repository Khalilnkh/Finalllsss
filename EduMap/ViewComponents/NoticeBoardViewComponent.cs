using EduMap.DAL;
using EduMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduMap.ViewComponents
{
    public class NoticeBoardViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public NoticeBoardViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<NoticeBoard> noticeBoards = await _context.NoticeBoards.Where(s => s.IsDeleted == false).ToListAsync();
            return View(await Task.FromResult(noticeBoards));
        }
    }
}
