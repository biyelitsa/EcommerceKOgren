using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class ProductList
    {
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public int CategoryId { get; set; }
        public int FilterId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductImage { get; set; }
        public string? CompanyName { get; set; }
        public string? EmployeeName { get; set; }
        public string? CategoryName { get; set; }
        public string? UnitName { get; set; }
        public string? ColorName { get; set; }
        public string? SizeName { get; set; }
    }
}
