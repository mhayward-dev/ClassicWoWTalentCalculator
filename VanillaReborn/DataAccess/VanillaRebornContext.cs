using Microsoft.EntityFrameworkCore;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess
{
    public class VanillaRebornContext : DbContext
    {
        public VanillaRebornContext(DbContextOptions<VanillaRebornContext> options)
            : base(options)
        { }

        public DbSet<WarcraftClass> WarcraftClasses { get; set; }
        public DbSet<WarcraftClassSpecification> WarcraftClassSpecifications { get; set; }
        public DbSet<Talent> Talents { get; set; }
        public DbSet<TalentRank> TalentRanks { get; set; }
        public DbSet<TalentRequirement> TalentRequirements { get; set; }
        public DbSet<TalentIcon> TalentIcons { get; set; }
        public DbSet<NewsStory> NewsStories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TalentRequirement>().HasOne(tr => tr.RequiredTalent).WithOne()
                .HasForeignKey<TalentRequirement>(tr => tr.RequiredTalentId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
