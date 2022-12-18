using EduMap.Models;
using System.Collections;
using System.Collections.Generic;

namespace EduMap.ViewModels
{
    public class CourseIndexVm
    {
        public IEnumerable<CourseHome> CourseHomes { get; set; }
        public IEnumerable<CoursePage> CoursePages { get; set; }
    }
}
