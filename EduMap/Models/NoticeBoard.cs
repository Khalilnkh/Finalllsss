using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class NoticeBoard : BaseEntity
    {
        [StringLength(1000)]
        public string MainTitle { get; set; }
        [StringLength(1000)]
        public string Date { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

    }
}
