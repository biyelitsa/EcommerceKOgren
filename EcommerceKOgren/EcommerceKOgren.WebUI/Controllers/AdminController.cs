using EcommerceKOgren.DataAccess.Concrete;
using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.DTO.Responses;
using EcommerceKOgren.Entities.Entities;
using EcommerceKOgren.UOW.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceKOgren.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IUOW _uow;
        Context _db;
        GeneralResponses _response;
        public AdminController(Context db, GeneralResponses response, IUOW uow)
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
        [HttpDelete("{id:int}")]
        public Sizes Delete(int id)
        {
            var x = _db.Sizes.Find(id);
            _db.Sizes.Remove(x);
            _db.SaveChanges();
            return x;
        }

        [HttpPost(Name = "Create")]
        public GeneralResponses Create([FromBody] Product product)
        {
            try
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                _response.MsgSuccess = $"{product.ProductName} başarılı şekilde eklenmiştir";
            }
            catch (Exception ex)
            {
                _response.MsgSuccess = $"{product.ProductName} ekleme başarısız olmuştur.";
                _response.MsgError = ex.Message;
            }
            return _response;
        }
        [HttpPut(Name = "Update")]
        public GeneralResponses Update([FromBody] Product product)
        {
            try
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                _response.MsgSuccess = $"{product.ProductName} başarılı şekilde güncellendi";
            }
            catch (Exception ex)
            {
                _response.MsgSuccess = $"{product.ProductName} ekleme başarısız güncellenmedi.";
                _response.MsgError = ex.Message;
            }
            return _response;
        }
    }
}
