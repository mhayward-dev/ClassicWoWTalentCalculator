using System.Collections.Generic;
using System.Linq;
using WoWClassicNews.Models;

namespace WoWClassicNews.DataAccess.DataSeeder
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

            // Marksmanship
            var marksmanshipTalents = new List<Talent>
            {
                new Talent { TalentName = "Improved Concussive Shot", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_stun").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Concussive shot a 4% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Concussive shot a 8% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Concussive shot a 12% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Concussive shot a 16% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Concussive shot a 20% chance to stun the target for 3 sec." }
                } },
                new Talent { TalentName = "Efficiency", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_wizardmark").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Mana cost of your Shots and Stings by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Mana cost of your Shots and Stings by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Mana cost of your Shots and Stings by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the Mana cost of your Shots and Stings by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the Mana cost of your Shots and Stings by 10%." }
                } },
                new Talent { TalentName = "Improved Hunter's Mark", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_hunter_snipershot").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Ranged Atack Power bonus of your Hunter's Mark spell by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Ranged Atack Power bonus of your Hunter's Mark spell by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the Ranged Atack Power bonus of your Hunter's Mark spell by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the Ranged Atack Power bonus of your Hunter's Mark spell by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the Ranged Atack Power bonus of your Hunter's Mark spell by 15%." }
                } },
                new Talent { TalentName = "Lethal Shots", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_searingarrow").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your critical chance with ranged weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your critical chance with ranged weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your critical chance with ranged weapons by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your critical chance with ranged weapons by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your critical chance with ranged weapons by 5%." }
                } },
                new Talent { TalentName = "Aimed Shot", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "inv_spear_07").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "An aimed shot that increases ranged damage by 70." }
                } },
                new Talent { TalentName = "Improved Arcane Shot", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_impalingbolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Arcane Shot by 0.2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Arcane Shot by 0.4 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cooldown of your Arcane Shot by 0.6 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the cooldown of your Arcane Shot by 0.8 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the cooldown of your Arcane Shot by 1 sec." }
                    } },
                new Talent { TalentName = "Hawk Eye", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_townwatch").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your ranged weapons by 2." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your ranged weapons by 4." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the range of your ranged weapons by 6." }
                } },
                new Talent { TalentName = "Improved Serpent Sting", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_hunter_quickshot").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Serpent Sting by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Serpent Sting by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Serpent Sting by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Serpent Sting by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Serpent Sting by 10%." }
                } },
                new Talent { TalentName = "Mortal Shots", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_piercedamage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your ranged weapon critical strike damage bonus by 6%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your ranged weapon critical strike damage bonus by 12%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your ranged weapon critical strike damage bonus by 18%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your ranged weapon critical strike damage bonus by 24%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your ranged weapon critical strike damage bonus by 30%." }
                } },
                new Talent { TalentName = "Scatter Shot", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_golemstormbolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "A short-range shot that deals 50% weapon damage and disorients the target for 4 sec. Any damage caused will remove the effect. Turns off your attacks when used." }
                } },
                new Talent { TalentName = "Barrage", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_upgrademoonglaive").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Multi-Shot and Volley spells by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Multi-Shot and Volley spells by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Multi-Shot and Volley spells by 15%." }
                } },
                new Talent { TalentName = "Improved Scorpid Sting", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_hunter_criticalshot").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Stamina of targets affected by your Scorpid Sting by 10% of the amount of Strength reduced." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Stamina of targets affected by your Scorpid Sting by 20% of the amount of Strength reduced." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Stamina of targets affected by your Scorpid Sting by 30% of the amount of Strength reduced." }
                } },
                new Talent { TalentName = "Ranged Weapon Specialization", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "inv_weapon_rifle_06").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage you deal with ranged weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage you deal with ranged weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage you deal with ranged weapons by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage you deal with ranged weapons by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage you deal with ranged weapons by 5%." }
                } },
                new Talent { TalentName = "Trueshot Aura", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "ability_trueshot").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the attack power of party members within 45 yards by 50. Lasts 30 min." }
                 } }
            };

            // Survival
            var survivalTalents = new List<Talent>
            {
                new Talent { TalentName = "Monster Slaying", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "inv_misc_head_dragon_black").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases all damage caused against Beasts, Giants and Dragonkin targets by 1% and increases critical damage caused against Beasts, Giants and Dragonkin targets by an additional 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases all damage caused against Beasts, Giants and Dragonkin targets by 2% and increases critical damage caused against Beasts, Giants and Dragonkin targets by an additional 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases all damage caused against Beasts, Giants and Dragonkin targets by 3% and increases critical damage caused against Beasts, Giants and Dragonkin targets by an additional 3%." }
                } },
                new Talent { TalentName = "Humanoid Slaying", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_holy_prayerofhealing").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases all damage caused against Humanoid targets by 1% and increases critical damage caused against Humanoid targets by an additional 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases all damage caused against Humanoid targets by 2% and increases critical damage caused against Humanoid targets by an additional 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases all damage caused against Humanoid targets by 3% and increases critical damage caused against Humanoid targets by an additional 3%." }
                } },
                new Talent { TalentName = "Deflection", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_parry").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Parry chance by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Parry chance by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Parry chance by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Parry chance by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Parry chance by 5%." }
                } },
                new Talent { TalentName = "Entrapment", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_racial_bloodrage").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Immolcation Trap, Frost Trap, and Explosive Trap a 5% chance to entrap the target, preventing them from moving for 5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Immolcation Trap, Frost Trap, and Explosive Trap a 10% chance to entrap the target, preventing them from moving for 5 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Immolcation Trap, Frost Trap, and Explosive Trap a 15% chance to entrap the target, preventing them from moving for 5 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Immolcation Trap, Frost Trap, and Explosive Trap a 20% chance to entrap the target, preventing them from moving for 5 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Immolcation Trap, Frost Trap, and Explosive Trap a 25% chance to entrap the target, preventing them from moving for 5 sec." }
                } },
                new Talent { TalentName = "Savage Strikes", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "inv_spear_07").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of Raptor Strike and Mongoose Bite by 10%." } ,
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of Raptor Strike and Mongoose Bite by 20%." }
                } },
                new Talent { TalentName = "Improved Wing Clip", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_rogue_trip").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Wing Clip ability a 4% chance to immobilize the target for 5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Wing Clip ability a 8% chance to immobilize the target for 5 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Wing Clip ability a 12% chance to immobilize the target for 5 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Wing Clip ability a 16% chance to immobilize the target for 5 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Wing Clip ability a 20% chance to immobilize the target for 5 sec." }
                    } },
                new Talent { TalentName = "Clever Traps", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_timestop").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the duration of Freezing and Frost trap effects by 30% and the famage of Immolation and Explosive trap effects by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the duration of Freezing and Frost trap effects by 30% and the famage of Immolation and Explosive trap effects by 30%." }
                } },
                new Talent { TalentName = "Survivalist", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_twilight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases total health by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases total health by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases total health by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases total health by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases total health by 10%." }
                } },
                new Talent { TalentName = "Deterrence", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_whirlwind").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, increases your Dodge and Parry chance by 25% for 10 sec." }
                } },
                new Talent { TalentName = "Trip Mastery", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_golemstormbolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Decreases the chance enemies will resist trap effects by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Decreases the chance enemies will resist trap effects by 10%." },
                } },
                new Talent { TalentName = "Surefooted", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_kick").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases hit chance by 1% and increases the chance movement impairing effects will be resisted by an additional 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases hit chance by 2% and increases the chance movement impairing effects will be resisted by an additional 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases hit chance by 3% and increases the chance movement impairing effects will be resisted by an additional 15%." }
                } },
                new Talent { TalentName = "Improved Feign Death", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_rogue_feigndeath").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the chance your Feign Death ability will be resisted by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the chance your Feign Death ability will be resisted by 4%." }
                } },
                new Talent { TalentName = "Killer Instinct", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofstamina").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your critical strike chance with all attacks by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your critical strike chance with all attacks by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your critical strike chance with all attacks by 3%." }
                } },
                new Talent { TalentName = "Counterattack", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_warrior_challange").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "A strike that becomes active after parrying an opponent's attack. This attack deals 40 damage and immobilizes the target for 5 sec. Counterattack cannot be blocked, dodged, or parried." }
                } },
                new Talent { TalentName = "Lightning Reflexes", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_nature_invisibilty").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Agility by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Agility by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Agility by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Agility by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Agility by 15%." }
                } },
                new Talent { TalentName = "Wyvern Sting", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "inv_spear_02").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "A stinging shot that puts the target to sleep for 12 sec. Any damage will cancel the effect. When the target wakes up, the Sting causes 0 Nature damage over 12 sec. Only usable out of combat. Only one Sting per Hunter can be active on the target at a time." }
                } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Beast Mastery", SpecificationIndex = 0, SpecificationIcon = "ability_hunter_beasttaming.jpg", Talents = beastMasteryTalents },
                new WarcraftClassSpecification { SpecificationName = "Marksmanship", SpecificationIndex = 1, SpecificationIcon = "ability_marksmanship.jpg", Talents = marksmanshipTalents },
                new WarcraftClassSpecification { SpecificationName = "Survival", SpecificationIndex = 2, SpecificationIcon = "ability_hunter_swiftstrike.jpg", Talents = survivalTalents }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var beastMasteryTalents = wcs[0].Talents;
            var marksmanshipTalents = wcs[1].Talents;
            var survivalTalents = wcs[2].Talents;

            beastMasteryTalents.First(t => t.TalentName == "Frenzy").RequiredTalent = beastMasteryTalents.First(t => t.TalentName == "Ferocity");
            beastMasteryTalents.First(t => t.TalentName == "Bestial Wrath").RequiredTalent = beastMasteryTalents.First(t => t.TalentName == "Intimidation");

            marksmanshipTalents.First(t => t.TalentName == "Trueshot Aura").RequiredTalent = marksmanshipTalents.First(t => t.TalentName == "Barrage");
            marksmanshipTalents.First(t => t.TalentName == "Mortal Shots").RequiredTalent = marksmanshipTalents.First(t => t.TalentName == "Lethal Shots");

            survivalTalents.First(t => t.TalentName == "Counterattack").RequiredTalent = survivalTalents.First(t => t.TalentName == "Deterrence");
            survivalTalents.First(t => t.TalentName == "Wyvern Sting").RequiredTalent = survivalTalents.First(t => t.TalentName == "Killer Instinct");
        }
    }
}
