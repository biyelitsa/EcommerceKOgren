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
    public class OrderDal : BaseRepository<Order>, IOrderDal
    {
        public OrderDal(Context db) : base(db)
        {
        }

        public IQueryable<OrderList> GetOrderList()
        {
            return Set().Select(x => new OrderList
            {
                OrderId = x.Id,
                CustomerId = x.CustomerId,
                OrderDate = x.OrderDate,
                CompanyName = x.Customers.CompanyName,
                OrderNumber = x.OrderNumber
            });
        }
    }
}
