using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduMap.Models
{
    public class Category:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public int Count { get; set; }
        public List<EventsHome> EventsHomes { get; set; }






    }
}
