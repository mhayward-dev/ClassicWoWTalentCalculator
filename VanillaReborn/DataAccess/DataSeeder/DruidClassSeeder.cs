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
            // Balance
            var balanceTalents = new List<Talent>
            {
                new Talent { TalentName = "Improved Wrath", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_abolishmagic").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cast time of your Wrath spell by 0.1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cast time of your Wrath spell by 0.2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cast time of your Wrath spell by 0.3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the cast time of your Wrath spell by 0.4 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the cast time of your Wrath spell by 0.5 sec." }
                } },
                new Talent { TalentName = "Nature's Grasp", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_natureswrath").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "While active, any time the enemy strikes the caster they have a a 35% chance to be inflicted by Entangling Roots (Rank 1), Only usable outdoors. 1 charge. Lasts 45 sec." }
                } },
                new Talent { TalentName = "Improved Nature's Grasp", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_natureswrath").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 30%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 45%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 65%." }
                } },
                new Talent { TalentName = "Improved Entangling Roots", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_stranglevines").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 40% chance to avoid interruption caused by damage while casting Entangling Roots." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 70% chance to avoid interruption caused by damage while casting Entangling Roots." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 100% chance to avoid interruption caused by damage while casting Entangling Roots." }
                } },
                new Talent { TalentName = "Improved Moonfire", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_starfall").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage and critical strike chance of your Moonfire spell by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage and critical strike chance of your Moonfire spell by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage and critical strike chance of your Moonfire spell by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage and critical strike chance of your Moonfire spell by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage and critical strike chance of your Moonfire spell by 10%." }
                } },
                new Talent { TalentName = "Natural Weapons", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "inv_staff_01").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage you deal with physical attacks in all forms by 2%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage you deal with physical attacks in all forms by 4%" },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage you deal with physical attacks in all forms by 6%" },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage you deal with physical attacks in all forms by 8%" },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage you deal with physical attacks in all forms by 10%" }
                } },
                new Talent { TalentName = "Natural Shapeshifter", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_wispsplode").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the mana cost of all Shapeshifting by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the mana cost of all Shapeshifting by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the mana cost of all Shapeshifting by 30%." }
                } },
                new Talent { TalentName = "Improved Thorns", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_thorns").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage caused by your Thorns spell by 25%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage caused by your Thorns spell by 50%" },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage caused by your Thorns spell by 75%" }
                } },
                new Talent { TalentName = "Omen of Clarity", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_crystalball").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Imbues the Druid with natural energy. Each of the druids melee attacks has a chance to cause the caster to enter a Clearcasting state. The Clearcasting state reduces the cost of Mana, Rage or Energy cost of your next damage or healing spell or offensive ability by 100%. Lasts 10min." }
                } },
                new Talent { TalentName = "Nature's Reach", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_naturetouchgrow").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your Wrath, Entangling Roots, Faerie Fire, Moonfire, Starfire and Hurricane spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your Wrath, Entangling Roots, Faerie Fire, Moonfire, Starfire and Hurricane spells by 20%." }
                } },
                new Talent { TalentName = "Vengeance", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_nature_purge").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 20%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 40%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the Critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 60%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the Critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 80%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the Critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 100%." }
                } },
                new Talent { TalentName = "Improved Starfire", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_arcane_starfire").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cast time of Starfire by 0.1 sec and has a 3% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cast time of Starfire by 0.2 sec and has a 6% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cast time of Starfire by 0.3 sec and has a 9% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the cast time of Starfire by 0.4 sec and has a 12% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the cast time of Starfire by 0.5 sec and has a 15% chance to stun the target for 3 sec." }
                } },
                new Talent { TalentName = "Nature's Grace", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_naturesblessing").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "All spell criticals grace you with a blessing of nature, reducing the casting time of your next spell by 0.5 sec." }
                } },
                new Talent { TalentName = "Moonglow", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_sentinal").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Mana cost of your Moonfire, Starfire, Wrath, Healing Touch, Regrowth and Rejuvenation spells by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Mana cost of your Moonfire, Starfire, Wrath, Healing Touch, Regrowth and Rejuvenation spells by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Mana cost of your Moonfire, Starfire, Wrath, Healing Touch, Regrowth and Rejuvenation spells by 9%." }
                } },
                new Talent { TalentName = "Moonfury", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_nature_moonglow").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Starfire, Moonfire and Wrath spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Starfire, Moonfire and Wrath spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Starfire, Moonfire and Wrath spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Starfire, Moonfire and Wrath spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Starfire, Moonfire and Wrath spells by 10%." }
                 } },
                new Talent { TalentName = "Moonkin Form", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_nature_forceofnature").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Transforms the Druid into Moonkin form. While in this form the armour contribution from armour is increased by 360% and all party members within 30 yards have their spell critical chance increased by 3%. The Moonkin can only cast Balance spells while shapeshifted.<br/><br/>The act of shapeshifting frees the caster of Polymorph and Movement impairing effects." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Balance", SpecificationIndex = 0, SpecificationIcon = "spell_nature_starfall.jpg", Talents = balanceTalents },
                new WarcraftClassSpecification { SpecificationName = "Feral Combat", SpecificationIndex = 1, SpecificationIcon = "ability_racial_bearform.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2, SpecificationIcon = "spell_nature_healingtouch.jpg" }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            wcs[0].Talents.First(t => t.TalentName == "Improved Nature's Grasp").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[0].Talents.First(t => t.TalentName == "Nature's Grasp").Id,
                ClassId = wcs[0].WarcraftClassId
            };

            wcs[0].Talents.First(t => t.TalentName == "Vengeance").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[0].Talents.First(t => t.TalentName == "Improved Moonfire").Id,
                ClassId = wcs[0].WarcraftClassId
            };

            wcs[0].Talents.First(t => t.TalentName == "Omen of Clarity").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[0].Talents.First(t => t.TalentName == "Natural Weapons").Id,
                ClassId = wcs[0].WarcraftClassId
            };

            wcs[0].Talents.First(t => t.TalentName == "Moonfury").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[0].Talents.First(t => t.TalentName == "Nature's Grace").Id,
                ClassId = wcs[0].WarcraftClassId
            };
        }
    }
}
