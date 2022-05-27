using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Order : Base
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int CustomerId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customers { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
