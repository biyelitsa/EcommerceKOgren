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
    public class CityDal : BaseRepository<City>, ICityDal
    {
        public CityDal(Context db) : base(db)
        {
        }

        public IQueryable<CityList> GetCityList()
        {
            return Set().Select(x => new CityList
            {
                CityId = x.Id,
                CityName = x.CityName,
                CountryName = x.Country.CountryName
            });
        }

        public IQueryable<CityList> GetCountryList(int id)
        {
            return Set().Select(x => new CityList
            {
                CityId = x.Id,
                CityName = x.CityName,
                CountryName = x.Country.CountryName
            }).Where(x => x.CityId == id);
        }
    }
}
