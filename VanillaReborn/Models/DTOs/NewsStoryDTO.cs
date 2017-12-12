using Frameworks.Extensions;
using System;
using System.Collections.Generic;
using VanillaReborn.Models.Enums;

namespace VanillaReborn.Models.DTOs
{
    public class NewsStoryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SecondaryTitle { get; set; }
        public string StoryTypeDescription { get; set; }
        public AuthorDTO Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string PreviewHtml { get; set; }
        public string TopSectionHtml { get; set; }
        public string MidSectionHtml { get; set; }
        public string StoryImage { get; set; }
        public string TitleUrl { get; set; }
        public List<NewsTag> Tags { get; set; }

        public static NewsStoryDTO ToDTO(NewsStory ns)
        {
            return new NewsStoryDTO {
                Id = ns.Id,
                Title = ns.Title,
                SecondaryTitle = ns.SecondaryTitle,
                StoryTypeDescription = ((StoryTypes)ns.StoryType).FormattedName(),
                Author = AuthorDTO.ToDTO(ns.Author),
                PublishedDate = ns.PublishedDate,
                PreviewHtml = ns.PreviewHtml,
                TopSectionHtml = ns.TopSectionHtml,
                MidSectionHtml = ns.MidSectionHtml,
                StoryImage = $"/images/content/{ns.StoryImage}",
                TitleUrl = StringExtensions.URLFriendly(ns.Title)
            };
        }
    }
}
