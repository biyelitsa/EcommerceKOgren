using EcommerceKOgren.DataAccess.Abstract;
using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Concrete
{
    public class CustomerDal : BaseRepository<Customer>, ICustomerDal
    {
        public CustomerDal(Context db) : base(db)
        {
        }

        public IQueryable<CustomerList> GetCustomerList()
        {
            return Set().Select(x => new CustomerList
            {
                CustomerId = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                CityName = x.City.CityName,
                CountyName = x.County.CountyName,
                CountryName = x.Country.CountryName,
                BillingAddress = x.BillingAddress,
                BillingCity = x.BillingCity,
                BillingCountry = x.BillingCountry,
                BillingPostalCode = x.BillingPostalCode,
                Email = x.Email,
                PostalCode = x.PostalCode,
                ShipCity = x.ShipCity,
                ShipCountry = x.ShipCountry,
                ShipPostalCode = x.ShipPostalCode,
                Phone = x.Phone,
                ShipAdress = x.ShipAdress
            });
        }

        public IQueryable<CustomerSelect> GetCustomerSelect()
        {
            return Set().Select(x => new CustomerSelect
            {
                CustomerId = x.Id,
                CompanyName = x.CompanyName
            });
        }
    }
}
