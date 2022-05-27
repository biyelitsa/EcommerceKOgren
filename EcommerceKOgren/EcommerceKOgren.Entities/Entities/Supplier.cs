using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Supplier : Base
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public string? CompanyName { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactLastName { get; set; }
        public string? Street { get; set; }
        public string? Avenue { get; set; }
        public int? CityId { get; set; }
        public int? CountyId { get; set; }
        public int? CountryId { get; set; }
        public string? OutDoorNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public int DiscountRate { get; set; }
        public bool DiscountAvailable { get; set; }
        public string? Logo { get; set; }
        public int Rate { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }
        [ForeignKey("CountyId")]
        public County? County { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
