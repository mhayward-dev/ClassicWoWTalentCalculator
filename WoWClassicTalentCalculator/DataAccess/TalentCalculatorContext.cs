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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WarcraftClass>().HasMany(c => c.WarcraftClassSpecifications);
            modelBuilder.Entity<WarcraftClassSpecification>().HasMany(cs => cs.SpecificationTalents);
        }
    }
}
