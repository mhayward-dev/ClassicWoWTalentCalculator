using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class WarlockClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Affliction", SpecificationIndex = 0, SpecificationIcon = "spell_shadow_deathcoil.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Demonology", SpecificationIndex = 1, SpecificationIcon = "spell_shadow_metamorphosis.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Destruction", SpecificationIndex = 2, SpecificationIcon = "spell_shadow_rainoffire.jpg" }
            };
        }
    }
}
