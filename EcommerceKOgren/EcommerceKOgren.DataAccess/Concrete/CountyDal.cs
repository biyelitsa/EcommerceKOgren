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
    public class CountyDal : BaseRepository<County>, ICountyDal
    {
        public CountyDal(Context db) : base(db)
        {
        }

        public IQueryable<CountyList> GetCityId(int id)
        {
            return Set().Select(x => new CountyList
            {
                CountyId = x.Id,
                CountyName = x.CountyName,
                CityName = x.City.CityName
            });
        }

        public IQueryable<CountyList> GetCounties()
        {
            return Set().Select(x => new CountyList
            {
                CountyId = x.Id,
                CountyName = x.CountyName
            });
        }

        public IQueryable<CountyList> GetCountryId(int id)
        {
            return Set().Select(x => new CountyList
            {
                CountyId = x.Id,
                CountyName = x.CountyName,
                CountryName = x.Country.CountryName
            });
        }
    }
}
