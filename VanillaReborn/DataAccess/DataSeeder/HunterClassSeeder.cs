using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class HunterClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Beast Mastery", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Marksmanship", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Survival", SpecificationIndex = 2 }
            };
        }
    }
}
