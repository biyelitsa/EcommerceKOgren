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
    public class UnitDal : BaseRepository<Unit>, IUnitDal
    {
       
        public UnitDal(Context db) : base(db)
        {
            
        }

        public IQueryable<UnitList> GetUnitList()
        {
            return Set().Select(x => new UnitList
            {
                UnitId = x.Id,
                UnitName = x.UnitName
            });
        }
    }
}
