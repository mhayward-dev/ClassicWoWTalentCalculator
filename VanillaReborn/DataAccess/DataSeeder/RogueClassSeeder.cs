using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class RogueClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Assassination", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Combat", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Subtlety", SpecificationIndex = 2 }
            };
        }
    }
}
