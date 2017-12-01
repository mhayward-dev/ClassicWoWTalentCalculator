using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.DataSeeder
{
    public class WarlockClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Affliction", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Demonology", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Destruction", SpecificationIndex = 2 }
            };
        }
    }
}
