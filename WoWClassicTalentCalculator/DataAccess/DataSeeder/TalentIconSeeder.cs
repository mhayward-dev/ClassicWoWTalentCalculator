using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.DataSeeder
{
    public static class TalentIconSeeder
    {
        public static List<TalentIcon> SetupIcons()
        {
            return new List<TalentIcon> {
                new TalentIcon { FileName = "spell_nature_wispsplode" },
                new TalentIcon { FileName = "spell_fire_fireball" },
                new TalentIcon { FileName = "spell_nature_stoneclawtotem" },
                new TalentIcon {FileName =  "spell_nature_spiritarmor" },
                new TalentIcon { FileName = "spell_fire_immolation" },
                new TalentIcon { FileName = "spell_shadow_manaburn" },
                new TalentIcon { FileName = "spell_frost_frostward" },
                new TalentIcon { FileName = "spell_nature_callstorm" },
                new TalentIcon { FileName = "spell_fire_sealoffire" },
                new TalentIcon { FileName = "spell_nature_eyeofthestorm" },
                new TalentIcon { FileName = "spell_fire_elementaldevastation" },
                new TalentIcon { FileName = "spell_nature_stormreach" },
                new TalentIcon { FileName = "spell_fire_volcano" },
                new TalentIcon { FileName = "spell_lightning_lightningbolt01" },
                new TalentIcon { FileName = "spell_nature_wispheal" }
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
                //new TalentIcon { FileName = "" },
            };
        }
    }
}
