using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class RogueClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Assassination", SpecificationIndex = 0, SpecificationIcon = "ability_rogue_eviscerate.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Combat", SpecificationIndex = 1, SpecificationIcon = "ability_backstab.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Subtlety", SpecificationIndex = 2, SpecificationIcon = "ability_stealth.jpg" }
            };
        }
    }
}
