using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }
        public int DiscountRate { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? WhoUpdated { get; set; }
        [ForeignKey("OrderDetailId")]
        public Order? Orders { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
        [ForeignKey("SizeId")]
        public Sizes? Sizes { get; set; }
        [ForeignKey("ColorId")]
        public Colors? Colors { get; set; }
    }
}
