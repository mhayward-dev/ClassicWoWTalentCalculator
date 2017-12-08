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
        public DbSet<Talent> Talents { get; set; }
        public DbSet<TalentRank> TalentRanks { get; set; }
        public DbSet<TalentRequirement> TalentRequirements { get; set; }
        public DbSet<TalentIcon> TalentIcons { get; set; }
    }
}
