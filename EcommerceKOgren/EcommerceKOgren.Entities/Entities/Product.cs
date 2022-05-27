using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Product : Base
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int SupplierId { get; set; }
        public int FilterId { get; set; }
        public int CategoryId { get; set; }
        public int EmployeeId { get; set; }
        public int UnitId { get; set; }
        public int Stock { get; set; }
        public int UnitPrice { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int DiscountRate { get; set; }
        public bool DiscountAvailable { get; set; }
        public string? Picture { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier? Suppliers { get; set; }
        [ForeignKey("FilterId")]
        public Filter? Filter { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Categories { get; set; }
        [ForeignKey("SizeId")]
        public Sizes? Sizes { get; set; }
        [ForeignKey("ColorId")]
        public Colors? Colors { get; set; }
        [ForeignKey("UnitId")]
        public Unit? Unit { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
