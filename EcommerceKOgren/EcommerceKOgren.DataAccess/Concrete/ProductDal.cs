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
    public class ProductDal : BaseRepository<Product>, IProductDal
    {
        public ProductDal(Context db) : base(db)
        {
        }

        public IQueryable<ProductList> GetProductList(int id)
        {
            return Set().Select(x => new ProductList
            {
                ProductId = x.Id,
                ProductName = x.ProductName,
                ProductImage = x.Picture,
                CategoryName = x.Categories.CategoryName,
                CompanyName = x.Suppliers.CompanyName,
                UnitName = x.Unit.UnitName,
                EmployeeName = x.Employee.FirstName + " " + x.Employee.Surname,
                EmployeeId = x.Employee.Id,
                FilterId = x.Filter.Id
            }).Where(x => x.FilterId == id);
        }

        public IQueryable<ProductSelect> GetProductSelect()
        {
            return Set().Select(x => new ProductSelect
            {
                ProductId = x.Id,
                ProductName = x.ProductName
            });
        }

        public IQueryable<ProductList> ListByCategoryId(int id)
        {
            return Set().Select(x => new ProductList
            {
                ProductId = x.Id,
                ProductName = x.ProductName,
                ProductImage = x.Picture,
                CategoryName = x.Categories.CategoryName,
                CompanyName = x.Suppliers.CompanyName,
                UnitName = x.Unit.UnitName,
                EmployeeName = x.Employee.FirstName + " " + x.Employee.Surname,
                EmployeeId = x.Employee.Id,
                CategoryId = x.Categories.Id,
                FilterId = x.Filter.Id,
                ColorName = x.Colors.ColorName,
                SizeName = x.Sizes.SizeName
            }).Where(x => x.CategoryId == id);
        }

        public IQueryable<ProductList> ProductLists()
        {
            return Set().Select(x => new ProductList
            {
                ProductId = x.Id,
                ProductName = x.ProductName,
                ProductImage = x.Picture,
                CategoryName = x.Categories.CategoryName,
                CompanyName = x.Suppliers.CompanyName,
                UnitName = x.Unit.UnitName,
                EmployeeName = x.Employee.FirstName + " " + x.Employee.Surname,
                EmployeeId = x.Employee.Id,
                FilterId = x.Filter.Id
            });
        }
    }
}
