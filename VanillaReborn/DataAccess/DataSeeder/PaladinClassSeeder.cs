using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.DataSeeder
{
    public class PaladinClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            var holySpec = new List<Talent>
            {
                new Talent { TalentName = "Divine Strength", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_golemthunderclap").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Strength by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Strength by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Strength by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Strength by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Strength by 10%." }
                } },
                new Talent { TalentName = "Divine Intellect", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_sleep").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your total Intellect by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your total Intellect by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your total Intellect by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your total Intellect by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your total Intellect by 10%." }
                } },
                new Talent { TalentName = "Spiritual Focus", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_arcane_blink").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Flash of Light and Holy Light spells a 14% to not lose casting time when you take damage." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Flash of Light and Holy Light spells a 28% to not lose casting time when you take damage." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Flash of Light and Holy Light spells a 42% to not lose casting time when you take damage." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Flash of Light and Holy Light spells a 56% to not lose casting time when you take damage." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Flash of Light and Holy Light spells a 70% to not lose casting time when you take damage." }
                } },
                new Talent { TalentName = "Improved Seal of Righteousness", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_thunderbolt").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Seal of Righteousness and Judge,ent of Righteousness by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Seal of Righteousness and Judge,ent of Righteousness by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Seal of Righteousness and Judge,ent of Righteousness by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Seal of Righteousness and Judge,ent of Righteousness by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Seal of Righteousness and Judge,ent of Righteousness by 15%.." }
                } },
                new Talent { TalentName = "Healing Light", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_holybolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increase the amount healed by your Holy Light and Flash of Light spells by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increase the amount healed by your Holy Light and Flash of Light spells by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increase the amount healed by your Holy Light and Flash of Light spells by 12%." }
                } },
                new Talent { TalentName = "Consecration", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_innerfire").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Consecrates the land beneath the Paladin, doing 64 Holy damage over 8 sec to enemies who enter the area." }
                } },
                new Talent { TalentName = "Improved Lay on Hands", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_layonhands").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives the target of your Lay on Hands spell a 15% bonus to their armor value from items for 2 min. In addition, the cooldown for your Lay on Hands spell is reduced by 10 min." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives the target of your Lay on Hands spell a 30% bonus to their armor value from items for 2 min. In addition, the cooldown for your Lay on Hands spell is reduced by 20 min." }
                } },
                new Talent { TalentName = "Unyielding Faith", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_unyieldingfaith").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to resist Fear and Disorient effects by an additiona 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to resist Fear and Disorient effects by an additiona 10%." }
                } },
                new Talent { TalentName = "Illumination", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_greaterheal").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "After getting a critical effect from your Flash of Light, Holy Light, or Holy Shock heal spell, gives you a 20% chance to gain Mana equal to the base cost of the spell." },
                        new TalentRank { RankNo = 2, RankDescription = "After getting a critical effect from your Flash of Light, Holy Light, or Holy Shock heal spell, gives you a 40% chance to gain Mana equal to the base cost of the spell." },
                        new TalentRank { RankNo = 3, RankDescription = "After getting a critical effect from your Flash of Light, Holy Light, or Holy Shock heal spell, gives you a 60% chance to gain Mana equal to the base cost of the spell." },
                        new TalentRank { RankNo = 4, RankDescription = "After getting a critical effect from your Flash of Light, Holy Light, or Holy Shock heal spell, gives you a 80% chance to gain Mana equal to the base cost of the spell." },
                        new TalentRank { RankNo = 5, RankDescription = "After getting a critical effect from your Flash of Light, Holy Light, or Holy Shock heal spell, gives you a 100% chance to gain Mana equal to the base cost of the spell." }
                } },
                new Talent { TalentName = "Improved Blessing of Wisdom", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_sealofwisdom").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Blessing of Wisdom spell by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Blessing of Wisdom spell by 20%." }
                } },
                new Talent { TalentName = "Divine Favor", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_holy_heal").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, gives your next Flash of Light, Holy Light, or Holy Shock spell a 100% critical effect chance." }
                } },
                new Talent { TalentName = "Lasting Judgement", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_holy_healingaura").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the duration of your Judgement of Light and Judgement of Wisdom by 10 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the duration of your Judgement of Light and Judgement of Wisdom by 20 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the duration of your Judgement of Light and Judgement of Wisdom by 30 sec." }
                } },
                new Talent { TalentName = "Holy Power", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_holy_power").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical effect chance of your Holy spells by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical effect chance of your Holy spells by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical effect chance of your Holy spells by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical effect chance of your Holy spells by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical effect chance of your Holy spells by 5%." }
                } },
                new Talent { TalentName = "Holy Shock", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_holy_searinglight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Blasts the target with Holy energy, causing 204 to 221 Holy damage to an enemy, or 204 to 221 healing to an ally." }
                } }
            };

            var protectionSpec = new List<Talent>
            {
                new Talent { TalentName = "Improved Devotion Aura", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_golemthunderclap").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the armor bonus of your Devotion Aura by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the armor bonus of your Devotion Aura by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the armor bonus of your Devotion Aura by 15%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the armor bonus of your Devotion Aura by 20%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the armor bonus of your Devotion Aura by 25%." }
                } },
                new Talent { TalentName = "Redoubt", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_defend").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to block attacks with your shield by 6% after being victim of a critical strike. Lasts 10 sec or 5 blocks." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to block attacks with your shield by 12% after being victim of a critical strike. Lasts 10 sec or 5 blocks." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to block attacks with your shield by 18% after being victim of a critical strike. Lasts 10 sec or 5 blocks." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to block attacks with your shield by 24% after being victim of a critical strike. Lasts 10 sec or 5 blocks." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to block attacks with your shield by 30% after being victim of a critical strike. Lasts 10 sec or 5 blocks." }
                } },
                new Talent { TalentName = "Precision", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_rogue_ambush").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to hit with melee weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to hit with melee weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to hit with melee weapons by 3%." }
                } },
                new Talent { TalentName = "Guardian's Favor", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_holy_sealofprotection").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Blessing of Protection by 60 sec and increases the duration of your Blessing of Freedom by 3 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Blessing of Protection by 120 sec and increases the duration of your Blessing of Freedom by 6 sec." }
                } },
                new Talent { TalentName = "Toughness", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_holy_devotion").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increaes your armor value from items by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increaes your armor value from items by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increaes your armor value from items by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increaes your armor value from items by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increaes your armor value from items by 10%." }
                } },
                new Talent { TalentName = "Blessing of Kings", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_magic_magearmor").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Places a Blessing on the friendly target, increasing total stats by 10% for 5 min. Players may only have one Blessing on them per Paladin at any one time." }
                } },
                new Talent { TalentName = "Improved Righteous Fury", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_sealoffury").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of threat generated by your Righteous Fury spell by 16%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of threat generated by your Righteous Fury spell by 33%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the amount of threat generated by your Righteous Fury spell by 50%." }
                } },
                new Talent { TalentName = "Shield Specialization", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "inv_shield_06").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of damage absorbed by your shield by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of damage absorbed by your shield by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the amount of damage absorbed by your shield by 30%." }
                } },
                new Talent { TalentName = "Anticipation", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_magic_lesserinvisibilty").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Defense skill by 2." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Defense skill by 4." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Defense skill by 6." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Defense skill by 8." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Defense skill by 10." }
                } },
                new Talent { TalentName = "Improved Hammer of Justice", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_sealofmight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Decreases the cooldown of your Hammer of Justice spell by 5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Decreases the cooldown of your Hammer of Justice spell by 10 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Decreases the cooldown of your Hammer of Justice spell by 15 sec." }
                } },
                new Talent { TalentName = "Improved Concentration Aura", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_mindsooth").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Concentration Aura by an additional 5% and gives all group members affected by the aura an aditional 5% chance to resist Silence and Interrupt effects." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Concentration Aura by an additional 5% and gives all group members affected by the aura an aditional 5% chance to resist Silence and Interrupt effects." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of your Concentration Aura by an additional 5% and gives all group members affected by the aura an aditional 5% chance to resist Silence and Interrupt effects." }
                } },
                new Talent { TalentName = "Blessing of Sanctuary", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_lightningshield").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Places a Blessing on the friendly target, reducing damage dealt from all sources by up to 10 for 5 min. In addition, when the target blocks a melee attack the attacker will take 14 Holy damage. Players may only have one Blessing on them per Paladin at any one time." }
                } },
                new Talent { TalentName = "Reckoning", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofstrength").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 20% chance to gain an extra attack after being the victim of a critical strike." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 40% chance to gain an extra attack after being the victim of a critical strike." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 60% chance to gain an extra attack after being the victim of a critical strike." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 80% chance to gain an extra attack after being the victim of a critical strike." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 100% chance to gain an extra attack after being the victim of a critical strike." }
                } },
                new Talent { TalentName = "One-Handed Weapon Specialization", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "inv_sword_20").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage you deal with one-handed melee weapons by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage you deal with one-handed melee weapons by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage you deal with one-handed melee weapons by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage you deal with one-handed melee weapons by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage you deal with one-handed melee weapons by 10%." }
                } },
                new Talent { TalentName = "Holy Shield", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofprotection").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Places a Blessing on the friendly target, reducing damage dealt from all sources by up to 10 for 5 min. In addition, when the target blocks a melee attack the attacker will take 14 Holy damage. Players may only have one Blessing on them per Paladin at any one time." }
                } }
            };

            var restributionSpec = new List<Talent>
            {
                new Talent { TalentName = "Improved Blessing of Might", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_holy_fistofjustice").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the melee attack power bonus of your Blessing of Might by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the melee attack power bonus of your Blessing of Might by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the melee attack power bonus of your Blessing of Might by 12%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the melee attack power bonus of your Blessing of Might by 16%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the melee attack power bonus of your Blessing of Might by 20%." }
                } },
                new Talent { TalentName = "Benediction", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_windwalkon").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Mana cost of your Judgement and Seal spells by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Mana cost of your Judgement and Seal spells by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Mana cost of your Judgement and Seal spells by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the Mana cost of your Judgement and Seal spells by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the Mana cost of your Judgement and Seal spells by 15%." }
                } },
                new Talent { TalentName = "Improved Judgement", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_holy_righteousfury").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Decreases the cooldown of your Judgement spell by 1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Decreases the cooldown of your Judgement spell by 2 sec." }
                } },
                new Talent { TalentName = "Improved Seal of the Crusader", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_holy_holysmite").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the melee attack power bonus of your Seal of the Crusader and the Holy damage increase of your Judgement of the Crusader by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the melee attack power bonus of your Seal of the Crusader and the Holy damage increase of your Judgement of the Crusader by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the melee attack power bonus of your Seal of the Crusader and the Holy damage increase of your Judgement of the Crusader by 15%." }
                } },
                new Talent { TalentName = "Deflection", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_parry").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increaes your Parry chance by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increaes your Parry chance by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increaes your Parry chance by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increaes your Parry chance by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increaes your Parry chance by 5%." }
                } },
                new Talent { TalentName = "Vindication", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_vindication").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives the Paladin's damaging melee attacks a chance to reduce the target's Strength and Agility by 5% for 10 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives the Paladin's damaging melee attacks a chance to reduce the target's Strength and Agility by 10% for 10 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives the Paladin's damaging melee attacks a chance to reduce the target's Strength and Agility by 15% for 10 sec." }
                } },
                new Talent { TalentName = "Conviction", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_retributionaura").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your chance to get a critical strike with melee weapons by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your chance to get a critical strike with melee weapons by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your chance to get a critical strike with melee weapons by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your chance to get a critical strike with melee weapons by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your chance to get a critical strike with melee weapons by 5%." }
                } },
                new Talent { TalentName = "Seal of Command", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_warrior_innerrage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives the Paladin a chance to deal additional Holy damage equal to 70% of normal weapon damage. Only one Seal can be active on the Paladin at any one time. Lasts 30 sec.<br/>Unleashing the Seal's energy will judge an enemy, instantly causing 46.5 to 55.5 Holy damage, 93 to 102 if the target is stunned or incapacitated." }
                } },
                new Talent { TalentName = "Pursuit of Justice", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_holy_persuitofjustice").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases movement and mounted movement speed by 8%. This does not stack with other movement speed increasing effects." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases movement and mounted movement speed by 8%. This does not stack with other movement speed increasing effects." }
                } },
                new Talent { TalentName = "Eye for an Eye", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_eyeforaneye").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "All spell criticals against you cause 15% of the damage taken to the caster as well. The damage caused by Eye for an Eye will not exceed 50% of the Paladin's total health." },
                        new TalentRank { RankNo = 2, RankDescription = "All spell criticals against you cause 15% of the damage taken to the caster as well. The damage caused by Eye for an Eye will not exceed 50% of the Paladin's total health." }
                } },
                new Talent { TalentName = "Improved Retribution Aura", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_auraoflight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Retribution Aura by 25%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Retribution Aura by 50%." }
                } },
                new Talent { TalentName = "Two-Handed Weapon Specialization", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "inv_hammer_04").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage you deal with two-handed melee weapons by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage you deal with two-handed melee weapons by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage you deal with two-handed melee weapons by 6%." }
                    } },
                new Talent { TalentName = "Sanctity Aura", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofstrength").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases Holy damage done by party members within 30 yards by 10%. Players may only have one Aura on them per Paladin at any one time." }
                } },
                new Talent { TalentName = "Vengeance", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "ability_racial_avatar").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 3% bonus to Physical and Holy damage you deal for 8 sec after dealing a critical strike from a weapon swing, spell, or ability." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 6% bonus to Physical and Holy damage you deal for 8 sec after dealing a critical strike from a weapon swing, spell, or ability." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 9% bonus to Physical and Holy damage you deal for 8 sec after dealing a critical strike from a weapon swing, spell, or ability." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 12% bonus to Physical and Holy damage you deal for 8 sec after dealing a critical strike from a weapon swing, spell, or ability." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 15% bonus to Physical and Holy damage you deal for 8 sec after dealing a critical strike from a weapon swing, spell, or ability." }
                } },
                new Talent { TalentName = "Repentance", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_holy_prayerofhealing").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Puts the enemy target in a state of meditation, incapaciting them for up to 6 sec. Any damage caused will awaken the target. Only works against Humanoids." }
                } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Holy", SpecificationIndex = 0, SpecificationIcon = "spell_holy_holybolt.jpg", Talents = holySpec },
                new WarcraftClassSpecification { SpecificationName = "Protection", SpecificationIndex = 1, SpecificationIcon = "spell_holy_devotionaura.jpg", Talents = protectionSpec },
                new WarcraftClassSpecification { SpecificationName = "Retribution", SpecificationIndex = 2, SpecificationIcon = "spell_holy_auraoflight.jpg", Talents = restributionSpec }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var holyTalents = wcs[0].Talents;
            var protectionTalents = wcs[1].Talents;
            var retributionTalents = wcs[2].Talents;

            holyTalents.First(t => t.TalentName == "Divine Favor").RequiredTalent = holyTalents.First(t => t.TalentName == "Illumination");
            holyTalents.First(t => t.TalentName == "Holy Shock").RequiredTalent = holyTalents.First(t => t.TalentName == "Divine Favor");

            protectionTalents.First(t => t.TalentName == "Shield Specialization").RequiredTalent = protectionTalents.First(t => t.TalentName == "Redoubt");
            protectionTalents.First(t => t.TalentName == "Holy Shield").RequiredTalent = protectionTalents.First(t => t.TalentName == "Blessing of Sanctuary");

            retributionTalents.First(t => t.TalentName == "Vengeance").RequiredTalent = retributionTalents.First(t => t.TalentName == "Conviction");
        }
    }
}
