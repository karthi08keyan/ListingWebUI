using ListingScreenUI.Models;
using Microsoft.AspNetCore.Mvc;
    
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ListingScreenUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
           /* string apiUrl = _configuration.GetSection("AppSettings:ApiUrl").Value;
            ViewBag.ApiUrl = apiUrl;*/
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Items()
        {
            
            return View();
        }
        public IActionResult ItemsList()
        {
          
            return View();
        }
        public IActionResult Customer()
        {
          
            return View();
        }
        public IActionResult CustomerList()
        {
       
            return View();
        }
        public IActionResult BillService()
        {
            return View();
        }
        public IActionResult BillList()
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