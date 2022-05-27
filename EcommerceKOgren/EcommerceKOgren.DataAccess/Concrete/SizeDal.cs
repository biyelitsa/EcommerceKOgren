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
    public class SizeDal : BaseRepository<Sizes>, ISizeDal
    {
        public SizeDal(Context db) : base(db)
        {
        }

        public IQueryable<SizeList> SizesList()
        {
            return Set().Select(x => new SizeList
            {
                SizeId = x.Id,
                SizeName = x.SizeName
            });
        }
    }
}
