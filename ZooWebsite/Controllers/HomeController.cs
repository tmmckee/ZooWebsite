using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZooWebsite.Models;

namespace ZooWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("HomePage");
        }

        public ViewResult Tickets()
        {
            return View();
        }

        public ViewResult Animals()
        {
            return View();
        }

        public ViewResult DirectionsToZoo()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

     
    }
}
