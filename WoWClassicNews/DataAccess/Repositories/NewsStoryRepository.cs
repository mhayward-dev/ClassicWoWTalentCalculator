using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicNews.Models;

namespace WoWClassicNews.DataAccess.Repositories
{
    public class NewsStoryRepository : BaseRepository<NewsStory, NewsStoryRepository>
    {
        public NewsStoryRepository(WoWClassicNewsContext context) : base(context)
        {
            CurrentRepository = this;
        }

        public override NewsStoryRepository EagerLoad()
        {
            Query = Query.Include(ns => ns.Author);

            return this;
        }

        public Task<NewsStory> GetByIdAsync(int id, bool eagerLoad = false)
        {
            return eagerLoad ? 
                Task.FromResult(All().For(ns => ns.Id == id).EagerLoad().Results().FirstOrDefault()) 
                : base.GetByIdAsync(id);
        }

        public NewsStoryRepository ForPage(int pageNo)
        {
            var skipNo = (pageNo - 1) * 10;
            Query = Query.OrderByDescending(s => s.PublishedDate).Skip(skipNo).Take(10);

            return this;
        }
    }
}
