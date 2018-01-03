using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class MageClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            var arcaneTalents = new List<Talent>
            {
                new Talent { TalentName = "Arcane Subtlety", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_holy_dispelmagic").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces your target's resistance to all your spells by 10 and reduces the threat caused by your Arcane spells by 20%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces your target's resistance to all your spells by 10 and reduces the threat caused by your Arcane spells by 40%." }
                } },
                new Talent { TalentName = "Arcane Focus", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_holy_devotion").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the chance that the opponent can resist your Arcane spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the chance that the opponent can resist your Arcane spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the chance that the opponent can resist your Arcane spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the chance that the opponent can resist your Arcane spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the chance that the opponent can resist your Arcane spells by 10%." }
                } },
                new Talent { TalentName = "Improved Arcane Missiles", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_starfall").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 20% chance to avoid interruption caused by damage while channeling Arcane Missiles." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 40% chance to avoid interruption caused by damage while channeling Arcane Missiles." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 60% chance to avoid interruption caused by damage while channeling Arcane Missiles." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 80% chance to avoid interruption caused by damage while channeling Arcane Missiles." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 100% chance to avoid interruption caused by damage while channeling Arcane Missiles." }
                } },
                new Talent { TalentName = "Wand Specialization", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "inv_wand_01").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your damage with Wands by 13%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your damage with Wands by 25%." }
                } },
                new Talent { TalentName = "Magic Absorption", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_astralrecalgroup").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases all resistances by 2 and causes all spells you fully resist to restore 1% of you total mana. 1 sec. cooldown." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases all resistances by 4 and causes all spells you fully resist to restore 2% of you total mana. 1 sec. cooldown." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases all resistances by 6 and causes all spells you fully resist to restore 3% of you total mana. 1 sec. cooldown." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases all resistances by 8 and causes all spells you fully resist to restore 4% of you total mana. 1 sec. cooldown." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases all resistances by 10 and causes all spells you fully resist to restore 5% of you total mana. 1 sec. cooldown." }
                } },
                new Talent { TalentName = "Arcane Concentration", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_manaburn").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 2% chance of entering a Clearcasting state after any damage spell hits a target. The Clearcasting state reduces the mana cost of you next damage spell by 100%." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 4% chance of entering a Clearcasting state after any damage spell hits a target. The Clearcasting state reduces the mana cost of you next damage spell by 100%." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 6% chance of entering a Clearcasting state after any damage spell hits a target. The Clearcasting state reduces the mana cost of you next damage spell by 100%." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 8% chance of entering a Clearcasting state after any damage spell hits a target. The Clearcasting state reduces the mana cost of you next damage spell by 100%." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 10% chance of entering a Clearcasting state after any damage spell hits a target. The Clearcasting state reduces the mana cost of you next damage spell by 100%.." }
                } },
                new Talent { TalentName = "Magic Attunement", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_abolishmagic").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Amplify Magic and Dampen Magic spells by 25%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Amplify Magic and Dampen Magic spells by 50%." }
                } },
                new Talent { TalentName = "Improved Arcane Explosion", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_wispsplode").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Arcane Explosion spell by an additional 6%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Arcane Explosion spell by an additional 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Arcane Explosion spell by an additional 6%." }
                } },
                new Talent { TalentName = "Arcane Resilience", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_arcane_arcaneresilience").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your armor by an amount equal to 50% of your Intellect." }
                } },
                new Talent { TalentName = "Improved Mana Shield", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_detectlesserinvisibility").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Decreases the mana lost per point of damage taken when Mana Shield is active by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Decreases the mana lost per point of damage taken when Mana Shield is active by 20%." }
                } },
                new Talent { TalentName = "Improved Counterspell", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_frost_iceshock").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Counterspell a 50% chance to silence the target for 4 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Counterspell a 100% chance to silence the target for 4 sec." }
                } },
                new Talent { TalentName = "Arcane Meditation", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_siphonmana").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Allows 5% of your Mana regeneration to continue while casting." },
                        new TalentRank { RankNo = 2, RankDescription = "Allows 10% of your Mana regeneration to continue while casting." },
                        new TalentRank { RankNo = 3, RankDescription = "Allows 15% of your Mana regeneration to continue while casting." }
                } },
                new Talent { TalentName = "Presence of Mind", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_enchantarmor").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, your next Mage spell with a casting time less than 10 sec becomes an instant cast spell." }
                } },
                new Talent { TalentName = "Arcane Mind", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_charm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your maximum Mana by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your maximum Mana by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your maximum Mana by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your maximum Mana by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your maximum Mana by 10%." }
                } },
                new Talent { TalentName = "Arcane Instability", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_shadow_teleport").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your spell damage and critical strike chance by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your spell damage and critical strike chance by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your spell damage and critical strike chance by 3%." }
                 } },
                new Talent { TalentName = "Arcane Power", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_nature_lightning").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, your spells deal 30% more damage while costing 30% more mana mana to cast. This effect lasts 15 sec." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arcane", SpecificationIndex = 0, SpecificationIcon = "spell_holy_magicalsentry.jpg", Talents = arcaneTalents },
                new WarcraftClassSpecification { SpecificationName = "Fire", SpecificationIndex = 1, SpecificationIcon = "spell_fire_firebolt02.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Frost", SpecificationIndex = 2, SpecificationIcon = "spell_frost_frostbolt02.jpg" }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var arcaneTalents = wcs[0].Talents;
            var fireTalents = wcs[1].Talents;
            var frostTalents = wcs[2].Talents;

            arcaneTalents.First(t => t.TalentName == "Arcane Mind").RequiredTalent = arcaneTalents.First(t => t.TalentName == "Arcane Resilience");
            arcaneTalents.First(t => t.TalentName == "Arcane Instability").RequiredTalent = arcaneTalents.First(t => t.TalentName == "Presence of Mind");
            arcaneTalents.First(t => t.TalentName == "Arcane Power").RequiredTalent = arcaneTalents.First(t => t.TalentName == "Arcane Instability");

            //    marksmanshipTalents.First(t => t.TalentName == "Trueshot Aura").RequiredTalent = marksmanshipTalents.First(t => t.TalentName == "Barrage");
            //    marksmanshipTalents.First(t => t.TalentName == "Mortal Shots").RequiredTalent = marksmanshipTalents.First(t => t.TalentName == "Lethal Shots");

            //    survivalTalents.First(t => t.TalentName == "Counterattack").RequiredTalent = survivalTalents.First(t => t.TalentName == "Deterrence");
            //    survivalTalents.First(t => t.TalentName == "Wyvern Sting").RequiredTalent = survivalTalents.First(t => t.TalentName == "Killer Instinct");
        }
    }
}
