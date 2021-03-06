using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Abstract
{
    public interface ICityDal : IBaseRepository<City>
    {
        IQueryable<CityList> GetCityList();
        IQueryable<CityList> GetCountryList(int id);
    }
}
