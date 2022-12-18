using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class Teacher:BaseEntity
    {
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string FullName { get; set; }
        [StringLength(1000)]

        public string Profession { get; set; }
        [StringLength(1000)]
        public string FacebookLink { get; set; }
        [StringLength(1000)]
        public string PinterestLink { get; set; }
        [StringLength(1000)]
        public string TwitterLink { get; set; }
        [StringLength(1000)]
        public string VimeoLink { get; set; }
        [StringLength(1000)]
        public string AboutMe { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(2000)]
        public string Degree { get; set; }
        [StringLength(1000)]
        public string Experience { get; set; }
        [StringLength(1000)]
        public string Hobbies { get; set; }
        [StringLength(1000)]
        public string Facculty { get; set; }
        [StringLength(1000)]
        public string Mail { get; set; }
        [StringLength(1000)]
        public string Call { get; set; }
        [StringLength(1000)]
        public string Skype { get; set; }
    }
}
