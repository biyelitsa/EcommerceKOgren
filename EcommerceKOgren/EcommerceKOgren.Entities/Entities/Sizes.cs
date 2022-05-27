using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Sizes : Base
    {
        public Sizes()
        {
            Products = new HashSet<Product>();
        }
        public string? SizeName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
