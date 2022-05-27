using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Abstract
{
    public interface IProductDal : IBaseRepository<Product>
    {
        IQueryable<ProductList> GetProductList(int id);
        IQueryable<ProductSelect> GetProductSelect();
        IQueryable<ProductList> ListByCategoryId(int id);
        IQueryable<ProductList> ProductLists();
    }
}
