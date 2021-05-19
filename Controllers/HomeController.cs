using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileDevicesManagement.Models;

namespace MobileDevicesManagement.Controllers
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
            var ipaddress = Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4();
            _logger.LogInformation($"New request for index page. {ipaddress}");
            return View();
        }

        public IActionResult Privacy()
        {
            var ipaddress = Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4();
            _logger.LogInformation($"New request for privacy page. {ipaddress}");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
