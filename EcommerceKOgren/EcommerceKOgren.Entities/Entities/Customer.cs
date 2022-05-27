using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Customer : Base
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? CompanyName { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public int CountryId { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingPostalCode { get; set; }
        public string? ShipAdress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }
        //public DateTime RegistrationDate { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }
        [ForeignKey("CountyId")]
        public County? County { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
