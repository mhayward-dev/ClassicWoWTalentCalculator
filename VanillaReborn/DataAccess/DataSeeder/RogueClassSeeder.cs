using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class RogueClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            var assasinationSpec = new List<Talent>
            {
                new Talent { TalentName = "Improved Eviscerate", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_rogue_eviscerate").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Eviscerate ability by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Eviscerate ability by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Eviscerate ability by 15%." }
                } },
                new Talent { TalentName = "Remorseless Attacks", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_fiegndead").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "After killing an opponent that yields experience or honor, gives you a 20% increased critical strike chance on your next Sinister Strike, Backstab, Ambush, or Ghostly Strike. Lasts 20 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "After killing an opponent that yields experience or honor, gives you a 20% increased critical strike chance on your next Sinister Strike, Backstab, Ambush, or Ghostly Strike. Lasts 40 sec." }
                } },
                new Talent { TalentName = "Malice", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_racial_bloodrage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your critical strike chance by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your critical strike chance by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your critical strike chance by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your critical strike chance by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your critical strike chance by 5%." }
                } },
                new Talent { TalentName = "Ruthlessness", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_druid_disembowel").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your finishing moves a 60% chance to add a combo point to your target." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your finishing moves a 60% chance to add a combo point to your target." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your finishing moves a 60% chance to add a combo point to your target." }
                } },
                new Talent { TalentName = "Murder", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_deathscream").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases all damage caused against Humanoid, Giant, Beast and Dragonkin targets by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases all damage caused against Humanoid, Giant, Beast and Dragonkin targets by 2%." }
                } },
                new Talent { TalentName = "Improved Slice and Dice", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_rogue_slicedice").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the duration of your Slice and Dice ability by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the duration of your Slice and Dice ability by 30%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the duration of your Slice and Dice ability by 45%." }
                } },
                new Talent { TalentName = "Relentless Strikes", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_warrior_decisivestrike").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your finishing moves have a 20% chance per combo point to restore 25 energy." }
                } },
                new Talent { TalentName = "Improved Expose Armor", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_warrior_riposte").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the armor reduced by your Expose Armor by 25%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the armor reduced by your Expose Armor by 50%." }
                } },
                new Talent { TalentName = "Lethality", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_criticalstrike").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike damage bonus of your Sinister Strike, Gouge, Backstab, Ghostly Strike, and Hemorrhage abilities by 6%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike damage bonus of your Sinister Strike, Gouge, Backstab, Ghostly Strike, and Hemorrhage abilities by 12%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike damage bonus of your Sinister Strike, Gouge, Backstab, Ghostly Strike, and Hemorrhage abilities by 18%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike damage bonus of your Sinister Strike, Gouge, Backstab, Ghostly Strike, and Hemorrhage abilities by 24%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike damage bonus of your Sinister Strike, Gouge, Backstab, Ghostly Strike, and Hemorrhage abilities by 30%." }
                } },
                new Talent { TalentName = "Vile Poisons", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_rogue_feigndeath").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage dealth by your poisons by 4% and gives your poisons an additional 8% chance to resist dispel effects." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage dealth by your poisons by 8% and gives your poisons an additional 16% chance to resist dispel effects." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage dealth by your poisons by 12% and gives your poisons an additional 24% chance to resist dispel effects." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage dealth by your poisons by 16% and gives your poisons an additional 32% chance to resist dispel effects." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage dealth by your poisons by 20% and gives your poisons an additional 40% chance to resist dispel effects." }
                } },
                new Talent { TalentName = "Improved Poisons", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_poisons").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the chance to apply poisons to your target by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the chance to apply poisons to your target by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the chance to apply poisons to your target by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the chance to apply poisons to your target by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the chance to apply poisons to your target by 10%." }
                } },
                new Talent { TalentName = "Cold Blood", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_ice_lament").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, increases the critical strike chance of your next Sinister Strike, Backstab, Ambush, or Eviscerate by 100%." }
                } },
                new Talent { TalentName = "Improved Kidney Shot", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_rogue_kidneyshot").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "While affected by your Kidney Shot ability, the target receives an additional 3% damage from all sources." },
                        new TalentRank { RankNo = 2, RankDescription = "While affected by your Kidney Shot ability, the target receives an additional 6% damage from all sources." },
                        new TalentRank { RankNo = 3, RankDescription = "While affected by your Kidney Shot ability, the target receives an additional 39% damage from all sources." }
                } },
                new Talent { TalentName = "Seal Fate", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_shadow_chilltouch").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your critical strikes from abilities that add combo points have a 20% chance to add an additional combo point." },
                        new TalentRank { RankNo = 2, RankDescription = "Your critical strikes from abilities that add combo points have a 40% chance to add an additional combo point." },
                        new TalentRank { RankNo = 3, RankDescription = "Your critical strikes from abilities that add combo points have a 60% chance to add an additional combo point." },
                        new TalentRank { RankNo = 4, RankDescription = "Your critical strikes from abilities that add combo points have a 80% chance to add an additional combo point." },
                        new TalentRank { RankNo = 5, RankDescription = "Your critical strikes from abilities that add combo points have a 100% chance to add an additional combo point." }
                } },
                new Talent { TalentName = "Vigor", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_nature_earthbindtotem").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your maximum Energy by 10." }
                 } }
            };

            var combatSpec = new List<Talent>
            {
                new Talent { TalentName = "Improved Gouge", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_gouge").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect duration of your Gouge ability by 0.5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect duration of your Gouge ability by 1 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect duration of your Gouge ability by 1.5 sec." }
                } },
                new Talent { TalentName = "Improved Sinister Strike", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_ritualofsacrifice").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Energy cost of your Sinister Strike ability by 3." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Energy cost of your Sinister Strike ability by 5." }
                } },
                new Talent { TalentName = "Lightning Reflexes", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_invisibilty").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Dodge chance by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Dodge chance by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Dodge chance by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Dodge chance by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Dodge chance by 5%." }
                } },
                new Talent { TalentName = "Improved Backstab", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_backstab").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Backstab ability by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Backstab ability by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Backstab ability by 30%." }
                } },
                new Talent { TalentName = "Deflection", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_parry").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Parry chance by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Parry chance by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Parry chance by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Parry chance by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Parry chance by 5%." }
                } },
                new Talent { TalentName = "Precision", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_marksmanship").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to hit with melee weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to hit with melee weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to hit with melee weapons by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to hit with melee weapons by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to hit with melee weapons by 5%." }
                } },
                new Talent { TalentName = "Endurance", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadowward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Sprint and Evasion abilities by 45 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Sprint and Evasion abilities by 1.5 min." }
                } },
                new Talent { TalentName = "Riposte", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_warrior_challange").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "A strike that becomes active after parrying an opponent's attack. This attack deals 150% weapon damage and disarms the target for 6 sec." }
                } },
                new Talent { TalentName = "Improved Sprint", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_rogue_sprint").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives a 50% chance to remove all movement impairing effects when you activate your Sprint ability." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives a 100% chance to remove all movement impairing effects when you activate your Sprint ability." }
                } },
                new Talent { TalentName = "Improved Kick", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_kick").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Kick ability a 50% chance to silence the target for 2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Kick ability a 100% chance to silence the target for 2 sec." }
                } },
                new Talent { TalentName = "Dagger Specialization", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "inv_weapon_shortblade_05").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to get a critical strike with Daggers by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to get a critical strike with Daggers by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to get a critical strike with Daggers by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to get a critical strike with Daggers by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to get a critical strike with Daggers by 5%." }
                } },
                new Talent { TalentName = "Dual Wield Specialization", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_dualwield").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your offhand weapon by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your offhand weapon by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your offhand weapon by 30%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your offhand weapon by 40%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your offhand weapon by 50%." }
                } },
                new Talent { TalentName = "Mace Specialization", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "inv_mace_01").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your skill with Maces by 1, and gives you a 1% chance to stun your target for 3 sec with a mace." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your skill with Maces by 1, and gives you a 2% chance to stun your target for 3 sec with a mace." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your skill with Maces by 1, and gives you a 3% chance to stun your target for 3 sec with a mace." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your skill with Maces by 1, and gives you a 4% chance to stun your target for 3 sec with a mace." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your skill with Maces by 1, and gives you a 5% chance to stun your target for 3 sec with a mace." }
                } },
                new Talent { TalentName = "Blade Flurry", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_warrior_punishingblow").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your attack speed by 20%. In addition, attacks strike an additional nearby opponent. Lasts 15 sec." }
                } },
                new Talent { TalentName = "Sword Specialization", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "inv_sword_27").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 1% chance to get an extra attack on the same target after dealing daamge with your Sword." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 2% chance to get an extra attack on the same target after dealing daamge with your Sword." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 3% chance to get an extra attack on the same target after dealing daamge with your Sword." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 4% chance to get an extra attack on the same target after dealing daamge with your Sword." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 5% chance to get an extra attack on the same target after dealing daamge with your Sword." }
                } },
                new Talent { TalentName = "First Weapon Specialization", ColumnIndex = 3, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "inv_gauntlets_04").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to get a critical strike with Fist Weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to get a critical strike with Fist Weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to get a critical strike with Fist Weapons by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to get a critical strike with Fist Weapons by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to get a critical strike with Fist Weapons by 5%." }
                } },
                new Talent { TalentName = "Weapon Expertise", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofstrength").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your skill with Sword, Fist and Dagger weapons by 5." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your skill with Sword, Fist and Dagger weapons by 5." }
                } },
                new Talent { TalentName = "Aggression", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "ability_racial_avatar").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage of your Sinister Strike and Eviscerate abilities by 6%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage of your Sinister Strike and Eviscerate abilities by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage of your Sinister Strike and Eviscerate abilities by 6%." }
                } },
                new Talent { TalentName = "Adrenaline Rush", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadowworddominate").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Energy regeneration rate by 100%." }
                 } }
            };

            var subtletySpec = new List<Talent>
            {
                new Talent { TalentName = "Master of Deception", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_charm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the chance enemies have to detect you while in Stealth mode." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the chance enemies have to detect you while in Stealth mode (Rank 1)." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the chance enemies have to detect you while in Stealth mode (Rank 2)." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the chance enemies have to detect you while in Stealth mode (Rank 3)." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the chance enemies have to detect you while in Stealth mode (Rank 4)." }
                } },
                new Talent { TalentName = "Opportunity", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_warrior_warcry").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage dealt when striking from behind with your Backstab, Garrote, or Ambush abilities by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage dealt when striking from behind with your Backstab, Garrote, or Ambush abilities by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage dealt when striking from behind with your Backstab, Garrote, or Ambush abilities by 12%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage dealt when striking from behind with your Backstab, Garrote, or Ambush abilities by 16%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage dealt when striking from behind with your Backstab, Garrote, or Ambush abilities by 20%." }
                } },
                new Talent { TalentName = "Sleight of Hand", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_rogue_feint").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the chance you are critically hit by melee and ranged attacks by 1% and increases the threat reduction of your Feint ability by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the chance you are critically hit by melee and ranged attacks by 2% and increases the threat reduction of your Feint ability by 20%." }
                } },
                new Talent { TalentName = "Elusiveness", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_magic_lesserinvisibilty").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reability_stealthduces the cooldown of your Vanish and Blind abilities by 45 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Vanish and Blind abilities by 1.5 min." }
                } },
                new Talent { TalentName = "Camouflage", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_stealth").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your speed while stealthed by 3% and reduces the cooldown of your Stealth ability by 1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your speed while stealthed by 6% and reduces the cooldown of your Stealth ability by 2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your speed while stealthed by 9% and reduces the cooldown of your Stealth ability by 3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your speed while stealthed by 12% and reduces the cooldown of your Stealth ability by 4 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your speed while stealthed by 15% and reduces the cooldown of your Stealth ability by 5 sec." }
                } },
                new Talent { TalentName = "Initiative", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_fumble").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 25% chance to add an additional combo point to your target when using your Ambush, Garrote, or Cheap Shot ability." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 50% chance to add an additional combo point to your target when using your Ambush, Garrote, or Cheap Shot ability." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 75% chance to add an additional combo point to your target when using your Ambush, Garrote, or Cheap Shot ability." }
                } },
                new Talent { TalentName = "Ghostly Strike", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_curse").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "A strike that deals 125% weapon damage and increases your chance to dodge by 15% for 7 sec. Awards 1 combo point." }
                } },
                new Talent { TalentName = "Improved Ambush", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_rogue_ambush").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Ambush ability by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Ambush ability by 30%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Ambush ability by 45%." }
                } },
                new Talent { TalentName = "Setup", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_nature_mirrorimage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 15% chance to add a combo point to your target after dodging their attack or fully resisting one of their spells." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 30% chance to add a combo point to your target after dodging their attack or fully resisting one of their spells." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 45% chance to add a combo point to your target after dodging their attack or fully resisting one of their spells." }
                } },
                new Talent { TalentName = "Improved Sap", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_sap").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 30% chance to return to stealth mode after using your Sap ability." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 60% chance to return to stealth mode after using your Sap ability." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 90% chance to return to stealth mode after using your Sap ability." }
                } },
                new Talent { TalentName = "Serrated Blades", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "inv_sword_17").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Causes your attacks to ignore 0 of your target's Armor and increases the damage dealt by your Rupture ability by 10%. The amount of Armor reduced increases with your level." },
                        new TalentRank { RankNo = 2, RankDescription = "Causes your attacks to ignore 0 of your target's Armor and increases the damage dealt by your Rupture ability by 20%. The amount of Armor reduced increases with your level." },
                        new TalentRank { RankNo = 3, RankDescription = "Causes your attacks to ignore 0 of your target's Armor and increases the damage dealt by your Rupture ability by 30%. The amount of Armor reduced increases with your level." }
                } },
                new Talent { TalentName = "Heightened Senses", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_ambush").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Stealth detection and reduces the chance you are hit by spells and ranged attacks by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Stealth detection and reduces the chance you are hit by spells and ranged attacks by 4%. (Rank 1)" }
                } },
                new Talent { TalentName = "Preparation", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_antishadow").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, this ability immediately finishes the cooldown on your other Rogue abilities." }
                } },
                new Talent { TalentName = "Dirty Deeds", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_summonsuccubus").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Energy cost of your Cheap Shot and Garrote ablities by 10." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Energy cost of your Cheap Shot and Garrote ablities by 20." }
                } },
                new Talent { TalentName = "Hemorrhage", ColumnIndex = 3, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_lifedrain").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "An instant strike that damages the opponent and causes the target to hemorrhage, increasing any Physical damage dealt to the target by up to 3. Lasts 30 charges or 15 sec. Awards 1 combo point." }
                 } },
                new Talent { TalentName = "Deadliness", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "inv_weapon_crossbow_11").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Attack Power by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Attack Power by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Attack Power by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Attack Power by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Attack Power by 10%." }
                } },
                new Talent { TalentName = "Premeditation", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_shadow_possession").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When used, adds 2 combo points to you target. You must add to or use those combo points within 10 sec or the combo points are lost." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Assassination", SpecificationIndex = 0, SpecificationIcon = "ability_rogue_eviscerate.jpg", Talents = assasinationSpec },
                new WarcraftClassSpecification { SpecificationName = "Combat", SpecificationIndex = 1, SpecificationIcon = "ability_backstab.jpg", Talents = combatSpec },
                new WarcraftClassSpecification { SpecificationName = "Subtlety", SpecificationIndex = 2, SpecificationIcon = "ability_stealth.jpg", Talents = subtletySpec }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var assassinationTalents = wcs[0].Talents;
            var combatTalents = wcs[1].Talents;
            var subtletyTalents = wcs[2].Talents;

            assassinationTalents.First(t => t.TalentName == "Lethality").RequiredTalent = assassinationTalents.First(t => t.TalentName == "Malice");
            assassinationTalents.First(t => t.TalentName == "Seal Fate").RequiredTalent = assassinationTalents.First(t => t.TalentName == "Cold Blood");

            combatTalents.First(t => t.TalentName == "Riposte").RequiredTalent = combatTalents.First(t => t.TalentName == "Deflection");
            combatTalents.First(t => t.TalentName == "Dual Wield Specialization").RequiredTalent = combatTalents.First(t => t.TalentName == "Precision");
            combatTalents.First(t => t.TalentName == "Weapon Expertise").RequiredTalent = combatTalents.First(t => t.TalentName == "Blade Flurry");

            subtletyTalents.First(t => t.TalentName == "Hemorrhage").RequiredTalent = subtletyTalents.First(t => t.TalentName == "Serrated Blades");
            subtletyTalents.First(t => t.TalentName == "Premeditation").RequiredTalent = subtletyTalents.First(t => t.TalentName == "Preparation");
        }
    }
}
