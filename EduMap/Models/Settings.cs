using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class Settings:BaseEntity
    {
        [StringLength(2500)]
        public string Key { get; set; }
        [StringLength(2500)]

        public string Value { get; set; }
    }
}
