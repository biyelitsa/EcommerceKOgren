using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.Entities.Entities
{
    public class Employee : Base
    {
        public Employee()
        {
            Products = new HashSet<Product>();
            Managers = new HashSet<Employee>();
        }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }
        public int ManagerId { get; set; }
        public bool IsManager { get; set; }
        public string? Street { get; set; }
        public string? Avenue { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public int OutDoorNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateofBirth { get; set; }

        [ForeignKey("ManagerId")]
        public Employee? Manager { get; set; }
        public ICollection<Employee>? Managers { get; set; }

        [ForeignKey("CountyId")]
        public County? County { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
