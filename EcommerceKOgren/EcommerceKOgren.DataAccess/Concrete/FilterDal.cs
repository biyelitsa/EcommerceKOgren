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
    public class FilterDal : BaseRepository<Filter>, IFilterDal
    {
        public FilterDal(Context db) : base(db)
        {
        }

        public IQueryable<FilterList> FiltersList()
        {
            return Set().Select(x => new FilterList
            {
                FilterId = x.Id,
                FilterName = x.FilterName
            });
        }
    }
}
