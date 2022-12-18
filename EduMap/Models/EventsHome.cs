using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class EventsHome : BaseEntity
    {
        [StringLength(1000)]
        public string DataMonth { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        [StringLength(1000)]

        public string DateTime { get; set; }
        [StringLength(1000)]
        public string Location { get; set; }

  


    }
}
