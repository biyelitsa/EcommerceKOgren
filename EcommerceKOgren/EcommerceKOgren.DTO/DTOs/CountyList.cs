using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DTO.DTOs
{
    public class CountyList
    {
        public int CountyId { get; set; }
        public string? CountyName { get; set; }
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
    }
}
