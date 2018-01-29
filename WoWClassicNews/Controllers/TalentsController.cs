using Microsoft.AspNetCore.Mvc;
using VanillaReborn.Models;
using System.Diagnostics;

namespace VanillaReborn.Controllers
{
    public class TalentsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentPage = "Talents";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
