using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Colors : Base
    {
        public Colors()
        {
            Products = new HashSet<Product>();
        }
        public string? ColorName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
