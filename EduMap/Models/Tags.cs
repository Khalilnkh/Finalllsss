using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class Tags:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        public IEnumerable<CourseTag> CourseTags { get; set; }


    }
}
