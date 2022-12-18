using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class CourseFeatures : BaseEntity
    {
        [StringLength(1000)]
        public  DataType Time { get; set; }
        [StringLength(1000)]
        public string Duration { get; set; }
        [StringLength(1000)]
        public string ClassDuration { get; set; }
        [StringLength(1000)]
        public string SkillLevel { get; set; }
        [StringLength(1000)]
        public string Language { get; set; }
        [StringLength(1000)]
        public int StudentCount { get; set; }
        [StringLength(1000)]
        public int Assign { get; set; }
        [StringLength(1000)]
        public string CourseFee { get; set; }

        public int CourseHomeId { get; set; }
        public CourseHome CourseHome { get; set; }




    }
}
