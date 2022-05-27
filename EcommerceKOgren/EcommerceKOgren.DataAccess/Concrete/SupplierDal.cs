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
    public class SupplierDal : BaseRepository<Supplier>, ISupplierDal
    {
        public SupplierDal(Context db) : base(db)
        {
        }

        public IQueryable<SupplierList> GetSupplierList()
        {
            return Set().Select(x => new SupplierList
            {
                SupplierId = x.Id,
                CompanyName = x.CompanyName,
                FullAddress = $"{x.Street} St., {x.Avenue} Ave., No: {x.OutDoorNumber} City: {x.City.CityName}, County: {x.County.CountyName}, Country: {x.County.CountyName}",
                PhoneNumber = x.Phone
            });
        }
    }
}
