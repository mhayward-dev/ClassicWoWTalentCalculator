using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VanillaReborn.DataAccess;
using VanillaReborn.Models.DTOs;
using VanillaReborn.DataAccess.Repositories;
using VanillaReborn.ViewModels;
using Frameworks.Extensions;
using System;

namespace VanillaReborn.Controllers
{
    public class NewsController : Controller
    {
        private readonly VanillaRebornContext _context;
        private NewsStoryRepository newsRepository;

        public NewsController(VanillaRebornContext context)
        {
            _context = context;
            newsRepository = new NewsStoryRepository(context);
        }

        public async Task<IActionResult> Index()
        {
            var stories = await newsRepository.All().EagerLoad().ForPage(1).ResultsAsync();

            ViewBag.CurrentPage = "News";
            return View(stories.Select(s => NewsStoryDTO.ToDTO(s)));
        }

        [HttpGet("News/Page/{pageNo}")]
        public async Task<IActionResult> Page(int pageNo)
        {
            var stories = await newsRepository.All().ForPage(pageNo).ResultsAsync();

            ViewBag.CurrentPage = "News";
            return View(stories.Select(s => NewsStoryDTO.ToDTO(s)));
        }

        [HttpGet("News/{id}/{title}")]
        public async Task<IActionResult> ViewStory(int id, string title)
        {
            var article = await newsRepository.GetByIdAsync(id, true);

            if (article.IsNull())
            {
                return NotFound();
            }

            var friendlyUrl = StringExtensions.URLFriendly(article.Title);

            if (!string.Equals(friendlyUrl, title, StringComparison.Ordinal))
            {
                return RedirectToRoutePermanent("", new { id = id, title = friendlyUrl });
            }

            ViewBag.CurrentPage = "News";
            return View(NewsStoryDTO.ToDTO(article));
        }
    }
}
