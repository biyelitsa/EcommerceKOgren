using EcommerceKOgren.DataAccess.Concrete;
using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.DTO.Responses;
using EcommerceKOgren.Entities.Entities;
using EcommerceKOgren.UOW.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceKOgren.WebUI.Controllers
{
    public class ShopController : Controller
    {
        IUOW _uow;
        Context _db;
        GeneralResponses _response;
        public ShopController(Context db, GeneralResponses response, IUOW uow)
        {
            _db = db;
            _response = response;
            _uow = uow;
        }

        [HttpGet(Name = "GetList")]
        public IQueryable<ProductList> GetList()
        {
            return _uow._proRepos.ProductLists();
        }
        [HttpGet("{id:int}")]
        public Product GetFind(int id)
        {
            return _db.Products.Find(id);
        }
    }
}
