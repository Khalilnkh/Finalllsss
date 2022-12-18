using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class CourseDetail:BaseEntity
    {
        [StringLength(1000)]
        public string CourseImage { get; set; }
        [StringLength(1000)]

        public string CourseName { get; set; }
        [StringLength(1000)]

        public string CourseDescription { get; set; }
        [StringLength(1000)]

        public string AboutCourse { get; set; }
        [StringLength(1000)]

        public string AboutDescription { get; set; }
        [StringLength(1000)]

        public string Apply { get; set; }
        [StringLength(1000)]

        public string ApplyDescription { get; set; }
        [StringLength(1000)]

        public string Certification { get; set; }
        [StringLength(1000)]

        public string CertificationDescription { get; set; }

        
    }
}
