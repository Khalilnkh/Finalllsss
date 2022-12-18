using EduMap.Models;
using System.Collections.Generic;

namespace EduMap.ViewModels
{
    public class CourseDetailsVM
    {
        public CourseHome CourseHomes { get; set; }
        public CourseFeatures CourseFeatures { get; set; }
        public CourseDetail  CourseDetails { get; set; }
        public IEnumerable<Category>  Categories { get; set; }
        public CourseTag CourseTags { get; set; }
        public Blog Blogs { get; set; }
        public Dictionary<string, string> Settings { get; set; }

        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }






    }
}
