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
    public class ColorDal : BaseRepository<Colors>, IColorDal
    {
        public ColorDal(Context db) : base(db)
        {

        }

        public IQueryable<ColorList> ColorLists()
        {
            return Set().Select(x => new ColorList
            {
                ColorId = x.Id,
                ColorName = x.ColorName
            });
        }
    }
}
