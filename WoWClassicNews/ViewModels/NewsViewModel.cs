using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicNews.Models.DTOs;

namespace WoWClassicNews.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<NewsStoryDTO> Stories { get; set; }
        public List<int> PageNumbers { get; set; }
    }
}
