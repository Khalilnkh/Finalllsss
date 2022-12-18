using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class AboutStart:BaseEntity
    {

        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        [StringLength(1000)]

        public string Description { get; set; }
    }
}
