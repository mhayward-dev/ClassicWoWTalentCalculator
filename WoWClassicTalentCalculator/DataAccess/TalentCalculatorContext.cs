using Microsoft.EntityFrameworkCore;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess
{
    public class TalentCalculatorContext : DbContext
    {
        public TalentCalculatorContext(DbContextOptions<TalentCalculatorContext> options)
            : base(options)
        { }

        public DbSet<WarcraftClass> WarcraftClasses { get; set; }
        public DbSet<WarcraftClassSpecification> WarcraftClassSpecifications { get; set; }
        public DbSet<SpecificationTalent> SpecificationTalents { get; set; }
        public DbSet<TalentRank> TalentRanks { get; set; }
        public DbSet<TalentRequirement> TalentRequirements { get; set; }
        public DbSet<TalentIcon> TalentIcons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WarcraftClass>().HasMany(c => c.WarcraftClassSpecifications);
            modelBuilder.Entity<WarcraftClassSpecification>().HasMany(cs => cs.SpecificationTalents);
            modelBuilder.Entity<SpecificationTalent>().HasMany(st => st.TalentRanks);
            modelBuilder.Entity<TalentRank>().HasMany(tr => tr.TalentRequirements);
        }
    }
}
