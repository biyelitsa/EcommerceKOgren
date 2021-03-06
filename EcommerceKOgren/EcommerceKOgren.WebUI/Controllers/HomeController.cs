using EcommerceKOgren.DataAccess.Concrete;
using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.DTO.Responses;
using EcommerceKOgren.UOW.Abstract;
using EcommerceKOgren.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceKOgren.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {

            return View() ;
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Admin()
        {
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
