using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.DataSeeder
{
    public class MageClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arcane", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Fire", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Frost", SpecificationIndex = 2 }
            };
        }
    }
}
