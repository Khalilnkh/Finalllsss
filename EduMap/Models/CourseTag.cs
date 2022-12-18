namespace EduMap.Models
{
    public class CourseTag:BaseEntity
    {
        public int CourseHomeId { get; set; }
        public CourseHome CourseHome { get; set; }
        public int TagsId { get; set; }
        public Tags Tags { get; set; }
    }
}
