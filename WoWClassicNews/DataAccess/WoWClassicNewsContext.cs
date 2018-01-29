using Microsoft.EntityFrameworkCore;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess
{
    public class WoWClassicNewsContext : DbContext
    {
        public WoWClassicNewsContext(DbContextOptions<WoWClassicNewsContext> options)
            : base(options)
        { }

        public DbSet<WarcraftClass> WarcraftClasses { get; set; }
        public DbSet<WarcraftClassSpecification> WarcraftClassSpecifications { get; set; }
        public DbSet<Talent> Talents { get; set; }
        public DbSet<TalentRank> TalentRanks { get; set; }
        public DbSet<TalentIcon> TalentIcons { get; set; }
        public DbSet<NewsStory> NewsStories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
