using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class WarriorClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arms", SpecificationIndex = 0, SpecificationIcon = "ability_rogue_eviscerate.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Fury", SpecificationIndex = 1, SpecificationIcon = "ability_warrior_innerrage.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Protection", SpecificationIndex = 2, SpecificationIcon = "ability_warrior_defensivestance.jpg" }
            };
        }
    }
}
