using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Country : Base
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }
        public string? CountryName { get; set; }
        public ICollection<City>? Cities { get; set; }
    }
}
