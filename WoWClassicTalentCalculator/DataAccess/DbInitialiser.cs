using System;
using System.Collections.Generic;
using System.Linq;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess
{
    public static class DbInitialiser
    {
        public static void Initialise(TalentCalculatorContext context)
        {
            context.Database.EnsureCreated();

            if (context.WarcraftClasses.Any())
            {
                return;
            }

            var druidSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Balance", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Feral Combat", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2 }
            };

            var classes = new WarcraftClass[] {
                new WarcraftClass { ClassName = "Druid", WarcraftClassSpecifications = druidSpecs }
            };

            foreach (WarcraftClass c in classes)
            {
                context.WarcraftClasses.Add(c);
            }

            context.SaveChanges();
        }
    }
}
