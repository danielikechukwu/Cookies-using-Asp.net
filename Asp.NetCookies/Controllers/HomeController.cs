using Asp.NetCookies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace Asp.NetCookies.Controllers
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
            CookieOptions options = new CookieOptions();

            options.Expires = DateTime.Now.AddMinutes(1);

            options.IsEssential = true;

            options.Path = "/";

            HttpContext.Response.Cookies.Append("MyCookie", "ljsroifngvos;erivs;orngvs;eor", options);


            return View();
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