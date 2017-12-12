using System.ComponentModel;

namespace VanillaReborn.Models.Enums
{
    public enum StoryTypes
    {
        [Description("Site News")]
        NewsUpdate = 1 << 0,
        [Description("News")]
        GameNews = 1 << 1,
        [Description("Opinion")]
        OpinionPost = 1 << 2,
        [Description("Nostalgia")]
        NostalgiaPost = 1 << 3
    }
}
