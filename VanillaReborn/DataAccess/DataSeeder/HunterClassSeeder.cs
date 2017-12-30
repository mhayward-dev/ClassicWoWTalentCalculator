using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class HunterClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            // Beast Mastery
            var beastMasteryTalents = new List<Talent>
            {
                new Talent { TalentName = "Improved Aspect of the Hawk", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_ravenform").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "While Aspect of the Hawk is active, all normal ranged attacks have a 1% chance of increasing ranged attack speed by 30% for 12 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "While Aspect of the Hawk is active, all normal ranged attacks have a 2% chance of increasing ranged attack speed by 30% for 12 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "While Aspect of the Hawk is active, all normal ranged attacks have a 3% chance of increasing ranged attack speed by 30% for 12 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "While Aspect of the Hawk is active, all normal ranged attacks have a 4% chance of increasing ranged attack speed by 30% for 12 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "While Aspect of the Hawk is active, all normal ranged attacks have a 5% chance of increasing ranged attack speed by 30% for 12 sec." }
                } },
                new Talent { TalentName = "Endurance Training", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_reincarnation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Health of your pets by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Health of your pets by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the Health of your pets by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the Health of your pets by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the Health of your pets by 15%." }
                } },
                new Talent { TalentName = "Improved Eyes of the Beast", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_eyeoftheowl").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the duration of your Eyes of the Beast by 30 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the duration of your Eyes of the Beast by 60 sec." }
                } },
                new Talent { TalentName = "Improved Aspect of the Monkey", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_stranglevines").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Dodge bonus of your Aspect of the Monkey by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Dodge bonus of your Aspect of the Monkey by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the Dodge bonus of your Aspect of the Monkey by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the Dodge bonus of your Aspect of the Monkey by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the Dodge bonus of your Aspect of the Monkey by 5%." }
                } },
                new Talent { TalentName = "Thick Hide", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "inv_misc_pelt_bear_03").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the armour rating of your pets by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the armour rating of your pets by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the armour rating of your pets by 30%." }
                } },
                new Talent { TalentName = "Improved Revive Pet", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_hunter_beastsoothe").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Revive Pet's casting time is reduced by 3 sec, mana cost is reduced by 20%, and increases the amount your pet returns with by an additional 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Revive Pet's casting time is reduced by 6 sec, mana cost is reduced by 40%, and increases the amount your pet returns with by an additional 30%." }
                } },
                new Talent { TalentName = "Pathfinding", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_mount_jungletiger").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the speed bonus of your Aspect of the Cheetah and Aspect of the Pack by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the speed bonus of your Aspect of the Cheetah and Aspect of the Pack by 6%." }
                } },
                new Talent { TalentName = "Beastial Swiftness", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_druid_dash").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the outdoor movement speed of your pets by 30%." }                    
                } },
                new Talent { TalentName = "Unleashed Fury", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_bullrush").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your pets by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your pets by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your pets by 12%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your pets by 16%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your pets by 20%." }
                } },
                new Talent { TalentName = "Improved Mend Pet", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_hunter_mendpet").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives the Mend Pet spell a 15% chance of cleansing 1 Curse, Disease, Magic or Poison effect from the pet each tick." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives the Mend Pet spell a 50% chance of cleansing 1 Curse, Disease, Magic or Poison effect from the pet each tick." }
                } },
                new Talent { TalentName = "Ferocity", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "inv_misc_monsterclaw_04").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your pets by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your pets by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your pets by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike chance of your pets by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike chance of your pets by 15%." }
                } },
                new Talent { TalentName = "Spirit Bond", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_druid_demoralizingroar").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "While your pet is active, you and your pet will regenerate 1% of total health every 10 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "While your pet is active, you and your pet will regenerate 2% of total health every 10 sec." }
                } },
                new Talent { TalentName = "Intimidation", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_devour").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Command your pet to intimidate the target on the next successful melee attack, causing a high amount of threat and stunning the target for 3 sec." }
                } },
                new Talent { TalentName = "Beastial Discipline", ColumnIndex = 3, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_abolishmagic").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Focus regeneration of your pets by 20%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Focus regeneration of your pets by 20%." }
                } },
                new Talent { TalentName = "Frenzy", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "inv_misc_monsterclaw_03").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your pet a 20% chance to gain a 30% attack speed increase for 8 sec after dealing a critical strike." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your pet a 40% chance to gain a 30% attack speed increase for 8 sec after dealing a critical strike." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your pet a 60% chance to gain a 30% attack speed increase for 8 sec after dealing a critical strike." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your pet a 80% chance to gain a 30% attack speed increase for 8 sec after dealing a critical strike." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your pet a 100% chance to gain a 30% attack speed increase for 8 sec after dealing a critical strike." }
                 } },
                new Talent { TalentName = "Bestial Wrath", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "ability_druid_ferociousbite").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Send your pet into a rage causing 50% additional damage for 18 sec. While enraged, the beast does not feel pity or remorse or fear and it cannot be stopped unless killed." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Beast Mastery", SpecificationIndex = 0, SpecificationIcon = "ability_hunter_beasttaming.jpg", Talents = beastMasteryTalents },
                new WarcraftClassSpecification { SpecificationName = "Marksmanship", SpecificationIndex = 1, SpecificationIcon = "ability_marksmanship.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Survival", SpecificationIndex = 2, SpecificationIcon = "ability_hunter_swiftstrike.jpg" }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var beastMasteryTalents = wcs[0].Talents;
            var marksmanshipTalents = wcs[1].Talents;
            var survivalTalents = wcs[2].Talents;

            beastMasteryTalents.First(t => t.TalentName == "Frenzy").RequiredTalent = beastMasteryTalents.First(t => t.TalentName == "Ferocity");
            beastMasteryTalents.First(t => t.TalentName == "Bestial Wrath").RequiredTalent = beastMasteryTalents.First(t => t.TalentName == "Intimidation");

            //feralTalents.First(t => t.TalentName == "Blood Frenzy").RequiredTalent = feralTalents.First(t => t.TalentName == "Sharpened Claws");
            //feralTalents.First(t => t.TalentName == "Primal Fury").RequiredTalent = feralTalents.First(t => t.TalentName == "Sharpened Claws");
            //feralTalents.First(t => t.TalentName == "Heart of the Wild").RequiredTalent = feralTalents.First(t => t.TalentName == "Predatory Strikes");

            //restorationTalents.First(t => t.TalentName == "Nature's Swiftness").RequiredTalent = restorationTalents.First(t => t.TalentName == "Improved Healing Touch");
            //restorationTalents.First(t => t.TalentName == "Gift of Nature").RequiredTalent = restorationTalents.First(t => t.TalentName == "Insect Swarm");
            //restorationTalents.First(t => t.TalentName == "Swiftmend").RequiredTalent = restorationTalents.First(t => t.TalentName == "Tranquil Spirit");
        }
    }
}
