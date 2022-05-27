using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class County : Base
    {
        public County()
        {
            Employees = new HashSet<Employee>();
            Customers = new HashSet<Customer>();
            Suppliers = new HashSet<Supplier>();
        }
        public string? CountyName { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }
        public ICollection<Customer>? Customers { get; set; }
        public ICollection<Supplier>? Suppliers { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
