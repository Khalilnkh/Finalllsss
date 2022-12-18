using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class FooterSlider:BaseEntity
    {
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string FullName { get; set; }
        [StringLength(1000)]
        public string Position { get; set; }
    }
}
