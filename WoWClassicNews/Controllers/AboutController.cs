using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WoWClassicNews.Views
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentPage = "About";
            return View();
        }
    }
}