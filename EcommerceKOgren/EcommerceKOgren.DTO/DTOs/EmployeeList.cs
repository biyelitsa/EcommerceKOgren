using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class EmployeeList
    {
        public int EmployeeId { get; set; }
        public string? FullName { get; set; }
        public char Gender { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public string? ManagerName { get; set; }
        public bool IsManager { get; set; }
        public string? FullAddress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
