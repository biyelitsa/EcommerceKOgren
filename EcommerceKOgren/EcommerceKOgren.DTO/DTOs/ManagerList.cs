using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class ManagerList
    {
        public int ManagerId { get; set; }
        public string? Fullname { get; set; }
        public bool IsManager { get; set; }
    }
}
