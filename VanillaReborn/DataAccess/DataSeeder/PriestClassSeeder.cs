using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class PriestClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Discipline", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Holy", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Shadow", SpecificationIndex = 2 }
            };
        }
    }
}
