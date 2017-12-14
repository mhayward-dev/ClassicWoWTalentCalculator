using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class MageClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arcane", SpecificationIndex = 0, SpecificationIcon = "spell_holy_magicalsentry.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Fire", SpecificationIndex = 1, SpecificationIcon = "spell_fire_firebolt02.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Frost", SpecificationIndex = 2, SpecificationIcon = "spell_frost_frostbolt02.jpg" }
            };
        }
    }
}
