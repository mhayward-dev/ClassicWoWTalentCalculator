using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicTalentCalculator.DataAccess.DataSeeder;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess
{
    public static class DbSeeder
    {
        public static void Seed(TalentCalculatorContext context)
        {
            var icons = TalentIconSeeder.SetupIcons();
            foreach(var icon in icons)
            {
                context.Add(icon);
            }

            context.SaveChanges();

            var classes = new WarcraftClass[] {
                new WarcraftClass { ClassName = "Druid", WarcraftClassSpecifications = DruidClassSeeder.Setup(icons), Order = 1 },
                new WarcraftClass { ClassName = "Hunter", WarcraftClassSpecifications = HunterClassSeeder.Setup(icons), Order = 2 },
                new WarcraftClass { ClassName = "Mage", WarcraftClassSpecifications = MageClassSeeder.Setup(icons), Order = 3 },
                new WarcraftClass { ClassName = "Paladin", WarcraftClassSpecifications = PaladinClassSeeder.Setup(icons), Order = 4 },
                new WarcraftClass { ClassName = "Priest", WarcraftClassSpecifications = PriestClassSeeder.Setup(icons), Order = 5 },
                new WarcraftClass { ClassName = "Rogue", WarcraftClassSpecifications = RogueClassSeeder.Setup(icons), Order = 6 },
                new WarcraftClass { ClassName = "Shaman", WarcraftClassSpecifications = ShamanClassSeeder.Setup(icons), Order = 7 },
                new WarcraftClass { ClassName = "Warlock", WarcraftClassSpecifications = WarlockClassSeeder.Setup(icons), Order = 8 },
                new WarcraftClass { ClassName = "Warrior", WarcraftClassSpecifications = WarriorClassSeeder.Setup(icons), Order = 9 }
            };

            foreach (WarcraftClass c in classes)
            {
                context.WarcraftClasses.Add(c);
            }

            context.SaveChanges();
        }
    }
}
