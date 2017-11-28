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

            var hunterSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Beast Mastery", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Marksmanship", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Survival", SpecificationIndex = 2 }
            };

            var mageSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arcane", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Fire", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Frost", SpecificationIndex = 2 }
            };

            var paladinSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Holy", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Protection", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Retribution", SpecificationIndex = 2 }
            };

            var priestSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Discipline", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Holy", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Shadow", SpecificationIndex = 2 }
            };

            var rogueSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Assassination", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Combat", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Subtlety", SpecificationIndex = 2 }
            };

            var shamanSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Elemental", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Enhancement", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2 }
            };

            var warlockSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Afflication", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Demonology", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Destruction", SpecificationIndex = 2 }
            };

            var warriorSpecs = new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arms", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Fury", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Protection", SpecificationIndex = 2 }
            };

            var classes = new WarcraftClass[] {
                new WarcraftClass { ClassName = "Druid", WarcraftClassSpecifications = druidSpecs, Order = 1 },
                new WarcraftClass { ClassName = "Hunter", WarcraftClassSpecifications = hunterSpecs, Order = 2 },
                new WarcraftClass { ClassName = "Mage", WarcraftClassSpecifications = mageSpecs, Order = 3 },
                new WarcraftClass { ClassName = "Paladin", WarcraftClassSpecifications = paladinSpecs, Order = 4 },
                new WarcraftClass { ClassName = "Priest", WarcraftClassSpecifications = priestSpecs, Order = 5 },
                new WarcraftClass { ClassName = "Rogue", WarcraftClassSpecifications = rogueSpecs, Order = 6 },
                new WarcraftClass { ClassName = "Shaman", WarcraftClassSpecifications = shamanSpecs, Order = 7 },
                new WarcraftClass { ClassName = "Warlock", WarcraftClassSpecifications = warlockSpecs, Order = 8 },
                new WarcraftClass { ClassName = "Warrior", WarcraftClassSpecifications = warriorSpecs, Order = 9 },
            };

            foreach (WarcraftClass c in classes)
            {
                context.WarcraftClasses.Add(c);
            }

            context.SaveChanges();
        }
    }
}
