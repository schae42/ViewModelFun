using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            Models.Message message = new Models.Message("Lorem ipsum dolor sit amet,consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."); 
            return View("index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numberpage()
        {
            int[] array = { 1,2,3,10,43,5};
            Models.Number numlist = new Models.Number(array);
            return View("numbers", numlist);
        }
        [HttpGet("users")]
        public IActionResult Userspage()
        {
            string[] array = { "Moose Phillips","Sarah","Jerry","Rene Ricky","Barbarah"};
            Models.User peoplelist = new Models.User(array);
            return View("users", peoplelist);
        }
        [HttpGet("user")]
        public IActionResult Userpage()
        {
            string ppl = "Moose Phillips";
            Models.User person = new Models.User(ppl);
            return View("user", person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
