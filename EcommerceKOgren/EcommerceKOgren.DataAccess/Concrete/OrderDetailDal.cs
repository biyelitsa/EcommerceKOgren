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
    public class OrderDetailDal : BaseRepository<OrderDetail>, IOrderDetailDal
    {
        public OrderDetailDal(Context db) : base(db)
        {
        }

        public IQueryable<OrderDetailList> GetFatDetailList(int id)
        {
            return Set().Select(x => new OrderDetailList
            {
                Id = x.OrderDetailId,
                ProductId = x.ProductId,
                Amount = x.Amount,
                ProductName = x.Product.ProductName,
                UnitPrice = x.UnitPrice,
                Total = x.UnitPrice * x.Amount,
                ProductImage = x.Product.Picture
            }).Where(x => x.Id == id);
        }

        public string OrderStock(IQueryable<OrderDetailList> od)
        {
            int stockTotal = od.Sum(x => x.Stock - x.Amount);
            int Count = od.Count();
            return $"Stock Totals: {Count} numbers of products together with total stock of {stockTotal}";
        }

        public string OrderTotal(IQueryable<OrderDetailList> od)
        {
            decimal Total = od.Sum(x => x.Amount * x.UnitPrice);
            int Count = od.Count();
            return $"Invoice Totals: {Count} numbers of products together with total amount of {Total}";

        }
    }
}
