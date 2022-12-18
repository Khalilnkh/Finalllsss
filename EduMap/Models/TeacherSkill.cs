using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class TeacherSkill:BaseEntity
    {
        [StringLength(1000)]
        public string Skill { get; set; }
        [StringLength(1000)]
        public string Percentage { get; set; }
    }
}
