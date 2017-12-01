using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.DataSeeder
{
    public class WarriorClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arms", SpecificationIndex = 0 },
                new WarcraftClassSpecification { SpecificationName = "Fury", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Protection", SpecificationIndex = 2 }
            };
        }
    }
}
