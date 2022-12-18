using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class TeacherHobbies:BaseEntity
    {

        [StringLength(2000)]
        public string TeacherHobby { get; set; }
    }
}
