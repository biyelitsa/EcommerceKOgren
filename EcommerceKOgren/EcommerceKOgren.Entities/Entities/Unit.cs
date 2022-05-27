using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Unit : Base
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }
        public string? UnitName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
