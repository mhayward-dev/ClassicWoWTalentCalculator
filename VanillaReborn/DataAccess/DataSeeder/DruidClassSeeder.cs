using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class DruidClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Balance", SpecificationIndex = 0, SpecificationIcon = "spell_nature_starfall.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Feral Combat", SpecificationIndex = 1, SpecificationIcon = "ability_racial_bearform.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2, SpecificationIcon = "spell_nature_healingtouch.jpg" }
            };
        }
    }
}
