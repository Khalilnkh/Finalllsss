using EduMap.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduMap.Interfaces
{
    public interface ILayoutServices
    {
        Task<Dictionary<string, string>> GetSettingAsync();
        

    }
}
