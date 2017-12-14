using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public static class ShamanClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            // Elemental Talents
            var elementalTalents = new List<Talent>
            {
                new Talent { TalentName = "Convection", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_wispsplode").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 2%" },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 4%" },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 6%" },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 8%" },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 10%" }
                } },
                new Talent { TalentName = "Concussion", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_fire_fireball").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 1%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 2%" },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 3%" },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 4%" },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 5%" }
                } },
                new Talent { TalentName = "Earth's Grasp", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_stoneclawtotem").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the health of your Stoneclaw Totem by 25% and the radius of your Earthbind Totem by 10%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the health of your Stoneclaw Totem by 50% and the radius of your Earthbind Totem by 20%" }
                } },
                new Talent { TalentName = "Elemental Warding", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_spiritarmor").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces damage taken from Fire, Frost, and Nature effects by 4%" },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces damage taken from Fire, Frost, and Nature effects by 8%" },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces damage taken from Fire, Frost, and Nature effects by 12%" }
                } },
                new Talent { TalentName = "Call of Flame", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_fire_immolation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Fire Totems by 5%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Fire Totems by 10%" },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Fire Totems by 15%" }
                } },
                new Talent { TalentName = "Elemental Focus", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_manaburn").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 10% chance to enter a Clearcasting state after casting any Fire, Frost, or Nature damage spell. The Clearcasting state reduces the mana cost of your next damage spell by 100%" }
                } },
                new Talent { TalentName = "Reverberation", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_frost_frostward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Shock spells by 0.2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Shock spells by 0.4 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cooldown of your Shock spells by 0.6 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the cooldown of your Shock spells by 0.8 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the cooldown of your Shock spells by 1 sec." }
                } },
                new Talent { TalentName = "Call of Thunder", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_callstorm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Lightning Bolt and Chain Lightning spells by an additional 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Lightning Bolt and Chain Lightning spells by an additional 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Lightning Bolt and Chain Lightning spells by an additional 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike chance of your Lightning Bolt and Chain Lightning spells by an additional 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike chance of your Lightning Bolt and Chain Lightning spells by an additional 5%." }
                } },
                new Talent { TalentName = "Improved Fire Totems", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_sealoffire").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the delay before your Fire Nova Totem activates by 1 sec. and decreases the threat generated by your Magma Totem by 25%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the delay before your Fire Nova Totem activates by 2 sec. and decreases the threat generated by your Magma Totem by 50%." }
                } },
                new Talent { TalentName = "Eye of the Storm", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_nature_eyeofthestorm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 33% chance to gain the Focused Casting effect that lasts for 6 sec. after being the victim of a physical or physical critical strike. The Focused Casting effect prevents you from losing casting time when taking damage." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 66% chance to gain the Focused Casting effect that lasts for 6 sec. after being the victim of a physical or physical critical strike. The Focused Casting effect prevents you from losing casting time when taking damage." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 100% chance to gain the Focused Casting effect that lasts for 6 sec.after being the victim of a physical or physical critical strike.The Focused Casting effect prevents you from losing casting time when taking damage." }
                } },
                new Talent { TalentName = "Elemental Devastation", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_elementaldevastation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your offensive spell crits will increase your chance to get a critical strike with physical attacks by 3% for 10 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Your offensive spell crits will increase your chance to get a critical strike with physical attacks by 6% for 10 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Your offensive spell crits will increase your chance to get a critical strike with physical attacks by 9% for 10 sec." }
                } },
                new Talent { TalentName = "Storm Reach", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_stormreach").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your Lightning Bolt and Chain Lightning spells by 3 yards." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your Lightning Bolt and Chain Lightning spells by 6 yards." }
                } },
                new Talent { TalentName = "Elemental Fury", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_fire_volcano").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike damage bonus of your Searing, Magma, and Fire Nova Totems and your Fire, Frost, and Nature spells by 100%" }
                } },
                new Talent { TalentName = "Lightning Mastery", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_lightning_lightningbolt01").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Lightning Bolt and Chain Lightning spells by 0.2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Lightning Bolt and Chain Lightning spells by 0.4 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the casting time of your Lightning Bolt and Chain Lightning spells by 0.6 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the casting time of your Lightning Bolt and Chain Lightning spells by 0.8 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the casting time of your Lightning Bolt and Chain Lightning spells by 1 sec." }
                } },
                 new Talent { TalentName = "Elemental Mastery", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_nature_wispheal").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, this spell gives your next Fire, Frost, or Nature damage spell a 100% critical strike chance and reduces the mana cost by 100%." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Elemental", SpecificationIndex = 0, SpecificationIcon = "spell_nature_lightning.jpg", Talents = elementalTalents },
                new WarcraftClassSpecification { SpecificationName = "Enhancement", SpecificationIndex = 1, SpecificationIcon = "spell_nature_lightningshield.jpg" },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2, SpecificationIcon = "spell_nature_healingtouch.jpg" }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            wcs[0].Talents.First(t => t.TalentName == "Lightning Mastery").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[0].Talents.First(t => t.TalentName == "Call of Thunder").Id,
                ClassId = wcs[0].WarcraftClassId
            };

            wcs[0].Talents.First(t => t.TalentName == "Elemental Mastery").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[0].Talents.First(t => t.TalentName == "Elemental Fury").Id,
                ClassId = wcs[0].WarcraftClassId
            };
        }
    }
}
