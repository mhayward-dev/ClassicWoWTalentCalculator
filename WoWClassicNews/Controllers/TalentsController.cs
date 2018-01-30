using Microsoft.AspNetCore.Mvc;
using WoWClassicNews.Models;
using System.Diagnostics;
using Frameworks.Extensions;
using WoWClassicNews.DataAccess;
using WoWClassicNews.DataAccess.Repositories;

namespace WoWClassicNews.Controllers
{
    public class TalentsController : Controller
    {
        private readonly WoWClassicNewsContext _context;
        private WarcraftClassRepository wcRepository;

        public TalentsController(WoWClassicNewsContext context)
        {
            _context = context;
            wcRepository = new WarcraftClassRepository(context);
        }

        [HttpGet("Talents")]
        public IActionResult Index(string className)
        {
            var name = wcRepository.All().ForClassName(className).FirstResult();

            if (name.IsNull())
            {
                return RedirectToActionPermanent("Index", new { className = "Druid" });
            }

            ViewBag.CurrentPage = "Talents";
            ViewBag.ClassName = name.ClassName;

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
