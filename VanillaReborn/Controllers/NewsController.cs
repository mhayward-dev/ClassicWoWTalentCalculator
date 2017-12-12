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
using System.Collections.Generic;

namespace VanillaReborn.Controllers
{
    public class NewsController : Controller
    {
        private readonly VanillaRebornContext _context;
        private NewsStoryRepository newsRepository;
        private readonly int pageSize = 10;
        private int totalPages;

        public NewsController(VanillaRebornContext context)
        {
            _context = context;
            newsRepository = new NewsStoryRepository(context);
            totalPages = CalculateTotalPages().Result;
        }

        public async Task<IActionResult> Index()
        {
            var stories = await newsRepository.All().EagerLoad().ForPage(1).ResultsAsync();

            ViewBag.CurrentPage = "News";
            ViewBag.CurrentPageNo = 1;

            return View(new NewsViewModel()
            {
                Stories = stories.Select(s => NewsStoryDTO.ToDTO(s)),
                PageNumbers = GetPageNumbers()
            });
        }

        [HttpGet("News/Page/{pageNo}")]
        public async Task<IActionResult> Page(int pageNo)
        {
            if (pageNo == 1)
            {
                return RedirectToActionPermanent("Index");
            }

            var stories = await newsRepository.All().EagerLoad().ForPage(pageNo).ResultsAsync();

            ViewBag.CurrentPage = "News";
            ViewBag.CurrentPageNo = pageNo;

            return View(new NewsViewModel()
            {
                Stories = stories.Select(s => NewsStoryDTO.ToDTO(s)),
                PageNumbers = GetPageNumbers()
            });
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

        private async Task<int> CalculateTotalPages()
        {
            var totalStories = await newsRepository.CountAsync();
            return (totalStories + pageSize - 1) / pageSize;
        }

        private List<int> GetPageNumbers()
        {
            var pageNumbers = new List<int>();

            var minPage = 1;
            var minRange = Math.Max(minPage, ViewBag.CurrentPageNo - 2);
            var maxRange = Math.Min(totalPages, ViewBag.CurrentPageNo + 2);

            for (int i = minRange; i <= maxRange; i++)
            {
                pageNumbers.Add(i);
            }

            return pageNumbers;
        }
    }
}
