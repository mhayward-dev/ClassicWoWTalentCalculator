using Microsoft.AspNetCore.Mvc;
using WoWClassicTalentCalculator.Models;
using System.Diagnostics;

namespace WoWClassicTalentCalculator.Controllers
{
    public class TalentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
