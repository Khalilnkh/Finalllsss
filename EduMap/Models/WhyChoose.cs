using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class WhyChoose:BaseEntity
    {
        [StringLength(1000)]
        public string MainTitle { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(1000)]

        public string PageLink { get; set; }
    }
}
