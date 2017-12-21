using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public static class ShamanClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            // Elemental
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
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 100% chance to gain the Focused Casting effect that lasts for 6 sec. after being the victim of a physical or physical critical strike. The Focused Casting effect prevents you from losing casting time when taking damage." }
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

            // Enhancement
            var enhancementTalents = new List<Talent> {
                new Talent { TalentName = "Ancestral Knowledge", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_grimward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your maximum Mana by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your maximum Mana by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your maximum Mana by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your maximum Mana by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your maximum Mana by 5%." }
                } },
                new Talent { TalentName = "Shield Specialization", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "inv_shield_06").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to block attacks with shields by 1% and increases the amount blocked by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to block attacks with shields by 2% and increases the amount blocked by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to block attacks with shields by 3% and increases the amount blocked by 15%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to block attacks with shields by 4% and increases the amount blocked by 20%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to block attacks with shields by 5% and increases the amount blocked by 25%." }
                } },
                new Talent { TalentName = "Guardian Totems", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_stoneskintotem").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of damage reduced by your Stoneskin Totem and Windwall Totem by 10% and reduces the cooldown of your Grounding Totem by 1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of damage reduced by your Stoneskin Totem and Windwall Totem by 20% and reduces the cooldown of your Grounding Totem by 2 sec." }
                } },
                new Talent { TalentName = "Thundering Strikes", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_thunderbolt").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Improves your chance to get a critical strike with your weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Improves your chance to get a critical strike with your weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Improves your chance to get a critical strike with your weapons by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Improves your chance to get a critical strike with your weapons by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Improves your chance to get a critical strike with your weapons by 5%." }
                } },
                new Talent { TalentName = "Improved Ghost Wolf", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_spiritwolf").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cast time of your Ghost Wolf spell by 1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cast time of your Ghost Wolf spell by 2 sec." }
                } },
                new Talent { TalentName = "Improved Lightning Shield", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_lightningshield").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Lightning Shield orbs by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Lightning Shield orbs by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Lightning Shield orbs by 15%." }
                } },
                new Talent { TalentName = "Enhancing Totems", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_earthbindtotem").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect if your Strength of Earth and Grace of Air totems by 8%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect if your Strength of Earth and Grace of Air totems by 15%." },
                    } },
                new Talent { TalentName = "Two-Handed Axes and Maces", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "inv_axe_10").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Allows you to use Two-Handed Axes and Two-Handed Maces" }
                    } },
                new Talent { TalentName = "Anticipation", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_mirrorimage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to dodge by an additional 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to dodge by an additional 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to dodge by an additional 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to dodge by an additional 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to dodge by an additional 5%." }
                    } },
                new Talent { TalentName = "Flurry", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_ghoulfrenzy").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your attack speed by 10% for your next 3 swings after dealing a critical strike." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your attack speed by 15% for your next 3 swings after dealing a critical strike." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your attack speed by 20% for your next 3 swings after dealing a critical strike." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your attack speed by 25% for your next 3 swings after dealing a critical strike." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your attack speed by 30% for your next 3 swings after dealing a critical strike." }
                    } },
                new Talent { TalentName = "Toughness", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_devotion").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your armour value from items by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your armour value from items by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your armour value from items by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your armour value from items by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your armour value from items by 10%." }
                    } },
                new Talent { TalentName = "Improved Weapon Totems", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_fire_enchantweapon").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the melee attack power bonus of your Windfury Totem by 15% and increases the damage caused by Flametongue totem by 6%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the melee attack power bonus of your Windfury Totem by 30% and increases the damage caused by Flametongue totem by 12%." }
                    } },
                new Talent { TalentName = "Elemental Weapons", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_fire_flametounge").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the melee attack power bonus of your Rockbiter Weapon by 7%, your Windfury Weapons effect by 13% and increases the damage by your Flametongue weapon and Frostband weapon by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the melee attack power bonus of your Rockbiter Weapon by 14%, your Windfury Weapons effect by 27% and increases the damage by your Flametongue weapon and Frostband weapon by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the melee attack power bonus of your Rockbiter Weapon by 20%, your Windfury Weapons effect by 40% and increases the damage by your Flametongue weapon and Frostband weapon by 15%." }
                    } },
                new Talent { TalentName = "Parry", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_parry").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives a chance to parry enemy melee attacks." },
                    } },
                new Talent { TalentName = "Weapon Mastery", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "ability_hunter_swiftstrike").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage you deal with all weapons by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage you deal with all weapons by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage you deal with all weapons by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage you deal with all weapons by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage you deal with all weapons by 10%." }
                    } },
                new Talent { TalentName = "Stormstrike", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_holy_sealofmight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you an extra attack. In addition, the next 2 sources of Nature damage dealt to the target are increased by 20%. Lasts 12 sec." },
                    } }
            };

            // Restoration
            var restorationTalents = new List<Talent> {
                new Talent { TalentName = "Improved Healing Wave", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_magicimmunity").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Healing Wave spell by 0.1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Healing Wave spell by 0.2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the casting time of your Healing Wave spell by 0.3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the casting time of your Healing Wave spell by 0.4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the casting time of your Healing Wave spell by 0.5%." }
                } },
                new Talent { TalentName = "Tidal Focus", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_manarecharge").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Mana cost of your healing spells by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Mana cost of your healing spells by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Mana cost of your healing spells by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the Mana cost of your healing spells by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the Mana cost of your healing spells by 5%." }
                } },
                new Talent { TalentName = "Improved Reincarnation", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_reincarnation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Reincarnation spell by 10 min and increases the amount of health and mana you Reincarnate by an additional 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Reincarnation spell by 20 min and increases the amount of health and mana you Reincarnate by an additional 20%." }
                } },
                new Talent { TalentName = "Ancestral Healing", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_undyingstrength").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your target's armour value by 8% for 15 sec after getting a critical effect from one of your healing spells." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your target's armour value by 16% for 15 sec after getting a critical effect from one of your healing spells." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your target's armour value by 25% for 15 sec after getting a critical effect from one of your healing spells." }
                } },
                new Talent { TalentName = "Totemic Focus", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_moonglow").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the mana cost of your Totems by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the mana cost of your Totems by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the mana cost of your Totems by 15%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the mana cost of your Totems by 20%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the mana cost of your Totems by 25%." }
                } },
                new Talent { TalentName = "Nature's Guidance", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_frost_stun").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to hit with melee attacks and spells by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to hit with melee attacks and spells by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to hit with melee attacks and spells by 3%." }
                } },
                new Talent { TalentName = "Healing Focus", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_healingwavelesser").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while casting any healing spell." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 28% chance to avoid interruption caused by damage while casting any healing spell." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 42% chance to avoid interruption caused by damage while casting any healing spell." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 56% chance to avoid interruption caused by damage while casting any healing spell." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 70% chance to avoid interruption caused by damage while casting any healing spell." }
                    } },
                new Talent { TalentName = "Totemic Mastery", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_nullward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "The radius of your totems that affect friendly targets is increased by 30 yd." }
                    } },
                new Talent { TalentName = "Healing Grace", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_healingtouch").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the threat generated by your healing spells by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the threat generated by your healing spells by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the threat generated by your healing spells by 15%." }
                    } },
                new Talent { TalentName = "Restorative Totems", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_nature_manaregentotem").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Mana Spring and Healing Stream Totems by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Mana Spring and Healing Stream Totems by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of your Mana Spring and Healing Stream Totems by 15%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the effect of your Mana Spring and Healing Stream Totems by 20%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the effect of your Mana Spring and Healing Stream Totems by 25%." }
                    } },
                new Talent { TalentName = "Tidal Mastery", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_nature_tranquility").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical effect chance of your healing and lightning spells by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical effect chance of your healing and lightning spells by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical effect chance of your healing and lightning spells by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical effect chance of your healing and lightning spells by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical effect chance of your healing and lightning spells by 5%." }
                    } },
                new Talent { TalentName = "Healing Way", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_healingway").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your Healing Wave spells have a 33% chance to increase the effect of subsequent Healing Wave spells on the target by 6% for 15 sec. This effect will stack up to 15001 times." },
                        new TalentRank { RankNo = 2, RankDescription = "Your Healing Wave spells have a 66% chance to increase the effect of subsequent Healing Wave spells on the target by 6% for 15 sec. This effect will stack up to 15001 times." },
                        new TalentRank { RankNo = 3, RankDescription = "Your Healing Wave spells have a 100% chance to increase the effect of subsequent Healing Wave spells on the target by 6% for 15 sec. This effect will stack up to 15001 times." }
                    } },
                new Talent { TalentName = "Nature's Swiftness", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_ravenform").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated your next Healing spell with cast time less than 10 sec. becomes an instant cast spell." }
                     } },
                new Talent { TalentName = "Purification", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_frost_wizardmark").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effectiveness of your healing spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effectiveness of your healing spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effectiveness of your healing spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the effectiveness of your healing spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the effectiveness of your healing spells by 10%." }
                    } },
                new Talent { TalentName = "Mana Tide Totem", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_frost_summonwaterelemental").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Summons a Mana Tide Totem with 5 health at the feet of the caster for 12 sec that restores 170 mana every 3 seconds to group members within 20 yards." },
                    } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Elemental", SpecificationIndex = 0, SpecificationIcon = "spell_nature_lightning.jpg", Talents = elementalTalents },
                new WarcraftClassSpecification { SpecificationName = "Enhancement", SpecificationIndex = 1, SpecificationIcon = "spell_nature_lightningshield.jpg", Talents = enhancementTalents },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2, SpecificationIcon = "spell_nature_healingtouch.jpg", Talents = restorationTalents }
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

            wcs[1].Talents.First(t => t.TalentName == "Flurry").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[1].Talents.First(t => t.TalentName == "Thundering Strikes").Id,
                ClassId = wcs[1].WarcraftClassId
            };

            wcs[1].Talents.First(t => t.TalentName == "Stormstrike").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[1].Talents.First(t => t.TalentName == "Elemental Weapons").Id,
                ClassId = wcs[1].WarcraftClassId
            };

            wcs[2].Talents.First(t => t.TalentName == "Mana Tide Totem").TalentRequirement =
            new TalentRequirement()
            {
                RequiredTalentId = wcs[2].Talents.First(t => t.TalentName == "Restorative Totems").Id,
                ClassId = wcs[2].WarcraftClassId
            };
        }
    }
}
