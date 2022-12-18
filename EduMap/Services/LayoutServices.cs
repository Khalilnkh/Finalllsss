using EduMap.DAL;
using EduMap.Interfaces;
using EduMap.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduMap.Services
{
    public class LayoutServices:ILayoutServices
    {
        private readonly AppDbContext _context;
        //private readonly IHttpContextAccessor _httpContextAccessor;


        public LayoutServices(AppDbContext context/*, IHttpContextAccessor httpContextAccessor*/)
        {
            _context = context;
            //_httpContextAccessor = httpContextAccessor;
        }

        

        public async Task<Dictionary<string, string>> GetSettingAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }
    }
}
