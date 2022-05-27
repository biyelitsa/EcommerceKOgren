using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Filter : Base
    {
        public Filter()
        {
            Categories = new HashSet<Category>();

            Products = new HashSet<Product>();
        }
        public string? FilterName { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
