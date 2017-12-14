using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class PaladinClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Holy", SpecificationIndex = 0, SpecificationIcon = "spell_holy_holybolt.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Protection", SpecificationIndex = 1, SpecificationIcon = "spell_holy_devotionaura.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Retribution", SpecificationIndex = 2, SpecificationIcon = "spell_holy_auraoflight.jpg" }
            };
        }
    }
}
