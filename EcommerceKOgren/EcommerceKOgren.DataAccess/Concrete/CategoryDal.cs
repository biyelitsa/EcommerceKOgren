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
    public class CategoryDal : BaseRepository<Category>, ICategoryDal
    {
        public CategoryDal(Context db) : base(db)
        {
        }
        public IQueryable<CategoryList> GetCategories()
        {
            return Set().Select(x => new CategoryList
            {
                CategoryId = x.Id,
                CategoryName = x.CategoryName
            });
        }
    }
}
