using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class CourseHome : BaseEntity
    {
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string MainTitle { get; set; }
        [StringLength(1000)]

        public string CourseImage { get; set; }
        [StringLength(1000)]
        public string CourseName { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<CourseFeatures> CourseFeatures { get; set; }
        public IEnumerable<CourseTag> CourseTags { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }








    }
}
