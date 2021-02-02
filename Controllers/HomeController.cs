using Dominus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;



namespace Dominus.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            ViewData["Tempo"] = DateTime.Now.Second.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
