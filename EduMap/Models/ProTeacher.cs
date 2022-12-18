using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class ProTeacher:BaseEntity
    {
        [StringLength(1000)]
        public string MainTitle { get; set; }
       
        [StringLength(2000)]
        public string Description { get; set; }
    }
}
