using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class OrderList
    {
        public int OrderId { get; set; }
        public string? CompanyName { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
