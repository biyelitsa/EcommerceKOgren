using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class OrderDetailList
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? ProductImage { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
        public int Stock { get; set; }
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }
    }
}
