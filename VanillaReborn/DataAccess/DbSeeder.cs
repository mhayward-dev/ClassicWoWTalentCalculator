using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VanillaReborn.DataAccess.DataSeeder;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess
{
    public static class DbSeeder
    {
        public static void Seed(TalentCalculatorContext context)
        {
            var talentIcons = TalentIconSeeder.SetupIcons();
            foreach(var icon in talentIcons)
            {
                context.Add(icon);
            }

            context.SaveChanges();

            var druid = new WarcraftClass { ClassName = "Druid", WarcraftClassSpecifications = DruidClassSeeder.Setup(talentIcons), Order = 1 };
            var hunter = new WarcraftClass { ClassName = "Hunter", WarcraftClassSpecifications = HunterClassSeeder.Setup(talentIcons), Order = 2 };
            var mage = new WarcraftClass { ClassName = "Mage", WarcraftClassSpecifications = MageClassSeeder.Setup(talentIcons), Order = 3 };
            var paladin = new WarcraftClass { ClassName = "Paladin", WarcraftClassSpecifications = PaladinClassSeeder.Setup(talentIcons), Order = 4 };
            var priest = new WarcraftClass { ClassName = "Priest", WarcraftClassSpecifications = PriestClassSeeder.Setup(talentIcons), Order = 5 };
            var rogue = new WarcraftClass { ClassName = "Rogue", WarcraftClassSpecifications = RogueClassSeeder.Setup(talentIcons), Order = 6 };
            var shaman = new WarcraftClass { ClassName = "Shaman", WarcraftClassSpecifications = ShamanClassSeeder.Setup(talentIcons), Order = 7 };
            var warlock = new WarcraftClass { ClassName = "Warlock", WarcraftClassSpecifications = WarlockClassSeeder.Setup(talentIcons), Order = 8 };
            var warrior = new WarcraftClass { ClassName = "Warrior", WarcraftClassSpecifications = WarriorClassSeeder.Setup(talentIcons), Order = 9 };

            var classes = new List<WarcraftClass> { druid, hunter, mage, paladin, priest, rogue, shaman, warlock, warrior };

            foreach (var wc in classes)
            {
                context.WarcraftClasses.Add(wc);
            }

            context.SaveChanges();

            ShamanClassSeeder.SetupTalentRequirements(shaman.WarcraftClassSpecifications);

            context.SaveChanges();
        }
    }
}
