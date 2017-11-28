using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WarcraftClass>().HasMany(c => c.WarcraftClassSpecifications);
            modelBuilder.Entity<WarcraftClassSpecification>().HasMany(cs => cs.Talents);
        }
    }
}
