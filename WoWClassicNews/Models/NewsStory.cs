using System;
using System.Collections.Generic;

namespace VanillaReborn.Models
{
    public class NewsStory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SecondaryTitle { get; set; }
        public int StoryType { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string PreviewHtml { get; set; }
        public string TopSectionHtml { get; set; }
        public string MidSectionHtml { get; set; }
        public string StoryImage { get; set; }
        public List<NewsTag> Tags { get; set; }
    }
}
