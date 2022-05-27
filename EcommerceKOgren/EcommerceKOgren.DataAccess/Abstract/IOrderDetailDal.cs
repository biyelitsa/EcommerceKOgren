using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Abstract
{
    public interface IOrderDetailDal : IBaseRepository<OrderDetail>
    {
        IQueryable<OrderDetailList> GetFatDetailList(int id);
        string OrderTotal(IQueryable<OrderDetailList> od);
        string OrderStock(IQueryable<OrderDetailList> od);
    }
}
