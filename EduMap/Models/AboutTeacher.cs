using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class AboutTeacher:BaseEntity
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

    }
}

