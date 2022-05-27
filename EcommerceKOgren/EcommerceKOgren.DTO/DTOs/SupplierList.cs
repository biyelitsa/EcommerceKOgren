using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class SupplierList
    {
        public int SupplierId { get; set; }
        public string? CompanyName { get; set; }
        public string? FullAddress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
