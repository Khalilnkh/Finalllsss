using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class Blog : BaseEntity
    {
        [StringLength(1000)]
        public string BlogImage { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        [StringLength(1000)]

        public string DateTime { get; set; }
        [StringLength(1000)]
        public int Comment { get; set; }

        [StringLength(2000)]
        public string Title { get; set; }

        public int CourseHomeId { get; set; }
        public CourseHome CourseHome { get; set; }
    }
}
