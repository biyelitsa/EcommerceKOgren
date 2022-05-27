using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class City : Base
    {
        public City()
        {
            Counties = new HashSet<County>();
        }
        public string? CityName { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }
        public ICollection<County>? Counties { get; set; }
    }
}
