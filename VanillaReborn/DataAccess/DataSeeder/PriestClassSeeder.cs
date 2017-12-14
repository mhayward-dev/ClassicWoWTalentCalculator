using System.Collections.Generic;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class PriestClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Discipline", SpecificationIndex = 0, SpecificationIcon = "spell_holy_wordfortitude.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Holy", SpecificationIndex = 1, SpecificationIcon = "spell_holy_holybolt.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Shadow", SpecificationIndex = 2, SpecificationIcon = "spell_shadow_shadowwordpain.jpg" }
            };
        }
    }
}
