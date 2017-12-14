using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class HunterClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Beast Mastery", SpecificationIndex = 0, SpecificationIcon = "ability_hunter_beasttaming.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Marksmanship", SpecificationIndex = 1, SpecificationIcon = "ability_marksmanship.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Survival", SpecificationIndex = 2, SpecificationIcon = "ability_hunter_swiftstrike.jpg" }
            };
        }
    }
}
