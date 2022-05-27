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
    public class CountryDal : BaseRepository<Country>, ICountryDal
    {
        public CountryDal(Context db) : base(db)
        {
        }

        public IQueryable<CountryList> GetCountryLists()
        {
            return Set().Select(x => new CountryList
            {
                CountryId = x.Id,
                CountryName = x.CountryName
            });
        }
    }
}
