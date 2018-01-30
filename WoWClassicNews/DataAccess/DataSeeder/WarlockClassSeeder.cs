using System.Collections.Generic;
using System.Linq;
using WoWClassicNews.Models;

namespace WoWClassicNews.DataAccess.DataSeeder
{
    public class WarlockClassSeeder
    {
        public static List<WarcraftClassSpecification> Setup(List<TalentIcon> icons)
        {
            var afflicationSpec = new List<Talent>
            {
                new Talent { TalentName = "Suppression", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_unsummonbuilding").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the chance for enemies to resist your Afflication spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the chance for enemies to resist your Afflication spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the chance for enemies to resist your Afflication spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the chance for enemies to resist your Afflication spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the chance for enemies to resist your Afflication spells by 10%." }
                } },
                new Talent { TalentName = "Improved Corruption", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_abominationexplosion").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Corruption spell by 0.4 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Corruption spell by 0.8 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the casting time of your Corruption spell by 1.2 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the casting time of your Corruption spell by 1.6 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the casting time of your Corruption spell by 2.0 sec." }
                } },
                new Talent { TalentName = "Improved Curse of Weakness", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_curseofmannoroth").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Curse of Weakness by 6%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Curse of Weakness by 13%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of your Curse of Weakness by 20%." }
                } },
                new Talent { TalentName = "Improved Drain Soul", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_haunting").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 100% chance to get a 150% increase to your Mana regeneration for 10 sec if the target is killed by you while you drain its soul. In addition your Mana may continue to regenerate while casting at 50% of normal." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 100% chance to get a 100% increase to your Mana regeneration for 10 sec if the target is killed by you while you drain its soul. In addition your Mana may continue to regenerate while casting at 50% of normal." }
                } },
                new Talent { TalentName = "Improved Life Tap", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_burningspirit").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of Mana awarded by your Life Tap spell by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of Mana awarded by your Life Tap spell by 20%." }
                } },
                new Talent { TalentName = "Improved Drain Life", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_lifedrain02").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Health drained by your Drain Life spell by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Health drained by your Drain Life spell by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the Health drained by your Drain Life spell by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the Health drained by your Drain Life spell by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the Health drained by your Drain Life spell by 10%." }
                } },
                new Talent { TalentName = "Improved Curse of Agony", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_curseofsargeras").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Curse of Agony by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Curse of Agony by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Curse of Agony by 6%." }
                } },
                new Talent { TalentName = "Fel Concentration", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_fingerofdeath").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while channeling the Drain Life, Drain Mana, or Drain Soul spell." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 28% chance to avoid interruption caused by damage while channeling the Drain Life, Drain Mana, or Drain Soul spell." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 42% chance to avoid interruption caused by damage while channeling the Drain Life, Drain Mana, or Drain Soul spell." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 56% chance to avoid interruption caused by damage while channeling the Drain Life, Drain Mana, or Drain Soul spell." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 70% chance to avoid interruption caused by damage while channeling the Drain Life, Drain Mana, or Drain Soul spell." }
                } },
                new Talent { TalentName = "Amplify Curse", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_contagion").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your next Curse of Weakness or Curse of Agony by 50%, or your next Curse of Exhaustion by 20%. Lasts 30 sec." }
                } },
                new Talent { TalentName = "Grim Reach", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_callofbone").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your Affliction spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your Affliction spells by 20%." }
                } },
                new Talent { TalentName = "Nightfall", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_twilight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Corruption and Drain Life spells a 2% chance to cause you to enter a Shadow Trance state after damaging the opponent. The Shadow Trance state reduces the casting time of your next Shadow Bolt spell by 100%." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Corruption and Drain Life spells a 4% chance to cause you to enter a Shadow Trance state after damaging the opponent. The Shadow Trance state reduces the casting time of your next Shadow Bolt spell by 100%." }
                } },
                new Talent { TalentName = "Improved Drain Mana", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_siphonmana").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Causes 15% of the Mana drained by your Drain Mana spell to damage the opponent." },
                        new TalentRank { RankNo = 2, RankDescription = "Causes 30% of the Mana drained by your Drain Mana spell to damage the opponent." }
                } },
                new Talent { TalentName = "Siphon Life", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_requiem").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Transfers 15 health from the target to the caster every 3 sec. Lasts 30 sec." }
                } },
                new Talent { TalentName = "Curse of Exhaustion", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_grimward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the target's movement speed by 10% for 12 sec. Only one Curse per Warlock can be active on any one target." }
                } },
                new Talent { TalentName = "Improved Curse of Exhaustion", ColumnIndex = 3, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_grimward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the speed reduction of your Curse of Exhaustion by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the speed reduction of your Curse of Exhaustion by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the speed reduction of your Curse of Exhaustion by 15%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the speed reduction of your Curse of Exhaustion by 20%." }
                } },
                new Talent { TalentName = "Shadow Mastery", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadetruesight").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage dealt or life drained by your Shadow spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage dealt or life drained by your Shadow spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage dealt or life drained by your Shadow spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage dealt or life drained by your Shadow spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage dealt or life drained by your Shadow spells by 10%." }
                } },
                new Talent { TalentName = "Dark Pact", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_shadow_darkritual").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Drains 150 of your pet's Mana, returning 100% to you." }
                 } }
            };

            var demonologySpec = new List<Talent>
            {
                new Talent { TalentName = "Improved Healthstone", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "inv_stone_04").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of Health restored by your Healthstone by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of Health restored by your Healthstone by 20%." }
                } },
                new Talent { TalentName = "Improved Imp", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_summonimp").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Imp's Firebolt, Fire Shield, and Blood Pact spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Imp's Firebolt, Fire Shield, and Blood Pact spells by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of your Imp's Firebolt, Fire Shield, and Blood Pact spells by 30%." }
                } },
                new Talent { TalentName = "Demonic Embrace", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_metamorphosis").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your total Stamina by 3% but reduces your total Spirit by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your total Stamina by 6% but reduces your total Spirit by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your total Stamina by 9% but reduces your total Spirit by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your total Stamina by 12% but reduces your total Spirit by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your total Stamina by 15% but reduces your total Spirit by 5%." }
                } },
                new Talent { TalentName = "Improved Health Funnel", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_lifedrain").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of Health transferred by your Health Funnel spell by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of Health transferred by your Health Funnel spell by 20%." }
                } },
                new Talent { TalentName = "Improved Voidwalker", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_summonvoidwalker").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effectiveness of your Voidwalker's Torment, Consume Shadows, Sacriface and Suffering spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effectiveness of your Voidwalker's Torment, Consume Shadows, Sacriface and Suffering spells by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effectiveness of your Voidwalker's Torment, Consume Shadows, Sacriface and Suffering spells by 30%." }
                } },
                new Talent { TalentName = "Fel Intellect", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_manaburn").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the maximum Mana of your Imp, Voidwalker, Succubus, and Felhunter by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the maximum Mana of your Imp, Voidwalker, Succubus, and Felhunter by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the maximum Mana of your Imp, Voidwalker, Succubus, and Felhunter by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the maximum Mana of your Imp, Voidwalker, Succubus, and Felhunter by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the maximum Mana of your Imp, Voidwalker, Succubus, and Felhunter by 15%." }
                } },
                new Talent { TalentName = "Improved Succubus", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_summonsuccubus").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Succubus' Lash of Pain and Soothing Kiss spells by 10%, and increases the duration of your Succubus' Seduction and Lesser Invisibility spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Succubus' Lash of Pain and Soothing Kiss spells by 20%, and increases the duration of your Succubus' Seduction and Lesser Invisibility spells by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of your Succubus' Lash of Pain and Soothing Kiss spells by 30%, and increases the duration of your Succubus' Seduction and Lesser Invisibility spells by 30%." }
                } },
                new Talent { TalentName = "Fel Domination", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_removecurse").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your next Imp, Voidwalker, Succubus, or Felhunter Summon spell has its casting time reduced by 5.5 and its Mana cost reduced by 50%." }
                } },
                new Talent { TalentName = "Fel Stamina", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_antishadow").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the maximum Health of your Imp, Voidwalker, Succubus, and Felhunter by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the maximum Health of your Imp, Voidwalker, Succubus, and Felhunter by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the maximum Health of your Imp, Voidwalker, Succubus, and Felhunter by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the maximum Health of your Imp, Voidwalker, Succubus, and Felhunter by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the maximum Health of your Imp, Voidwalker, Succubus, and Felhunter by 15%." }
                } },
                new Talent { TalentName = "Master Summoner", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_impphaseshift").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Imp, Voidwalker, Succubus, and Felhunter Summoning spells by 2 sec and the Mana cost by 20%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Imp, Voidwalker, Succubus, and Felhunter Summoning spells by 4 sec and the Mana cost by 40%." }
                } },
                new Talent { TalentName = "Unholy Power", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadowworddominate").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Voidwalker, Succubus, and Felhunter's melee attacks by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Voidwalker, Succubus, and Felhunter's melee attacks by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Voidwalker, Succubus, and Felhunter's melee attacks by 12%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Voidwalker, Succubus, and Felhunter's melee attacks by 16%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Voidwalker, Succubus, and Felhunter's melee attacks by 20%." }
                } },
                new Talent { TalentName = "Improved Enslave Demon", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_enslavedemon").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Attack Speed and Casting Speed penalty of your Enslave Demon spell by 2% and reduces the resist chance by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Attack Speed and Casting Speed penalty of your Enslave Demon spell by 4% and reduces the resist chance by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Attack Speed and Casting Speed penalty of your Enslave Demon spell by 6% and reduces the resist chance by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the Attack Speed and Casting Speed penalty of your Enslave Demon spell by 8% and reduces the resist chance by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the Attack Speed and Casting Speed penalty of your Enslave Demon spell by 10% and reduces the resist chance by 10%." }
                } },
                new Talent { TalentName = "Demonic Sacrifice", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_psychicscream").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, sacrifices your summoned demon to grant you a effect that lasts 30 min. The effect is canceled if any Demon is summoned.<br /><br />Imp: Increases your Fire damage by 15%.<br /><br />Voidwalker: Restores 3% of total Health every 4 sec.<br /><br />Succubus: Increases your Shadow damage by 15%.<br /><br />Felhunter: Restores 2% of total Mana every 4 sec." }
                } },
                new Talent { TalentName = "Improved Firestone", ColumnIndex = 3, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "inv_ammo_firetar").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the bonus Fire damage from Firestones and Firestone effect by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the bonus Fire damage from Firestones and Firestone effect by 30%." }
                } },
                new Talent { TalentName = "Master Demonologist", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadowpact").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Grants both the Warlock and the summoned demon an effect as long as that demon is active.<br /><br /> Imp - Reduces threat caused by 4%.<br /><br />Voidwalker - Reduces physical damage taken by 2%.<br /><br />Succubus - Increases all damage caused by 2%.<br /><br />Felhunter - Increases all resistances by .2 per level." },
                        new TalentRank { RankNo = 2, RankDescription = "Grants both the Warlock and the summoned demon an effect as long as that demon is active.<br /><br /> Imp - Reduces threat caused by 8%.<br /><br />Voidwalker - Reduces physical damage taken by 4%.<br /><br />Succubus - Increases all damage caused by 4%.<br /><br />Felhunter - Increases all resistances by .4 per level." },
                        new TalentRank { RankNo = 3, RankDescription = "Grants both the Warlock and the summoned demon an effect as long as that demon is active.<br /><br /> Imp - Reduces threat caused by 12%.<br /><br />Voidwalker - Reduces physical damage taken by 6%.<br /><br />Succubus - Increases all damage caused by 6%.<br /><br />Felhunter - Increases all resistances by .6 per level." },
                        new TalentRank { RankNo = 4, RankDescription = "Grants both the Warlock and the summoned demon an effect as long as that demon is active.<br /><br /> Imp - Reduces threat caused by 16%.<br /><br />Voidwalker - Reduces physical damage taken by 8%.<br /><br />Succubus - Increases all damage caused by 8%.<br /><br />Felhunter - Increases all resistances by .8 per level." },
                        new TalentRank { RankNo = 5, RankDescription = "Grants both the Warlock and the summoned demon an effect as long as that demon is active.<br /><br /> Imp - Reduces threat caused by 20%.<br /><br />Voidwalker - Reduces physical damage taken by 10%.<br /><br />Succubus - Increases all damage caused by 10%.<br /><br />Felhunter - Increases all resistances by 1 per level." }
                 } },
                new Talent { TalentName = "Soul Link", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_shadow_gathershadows").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, 30% of all damage taken by the caster is taken by your Imp, Voidwalker, Succubus, or Felhunter demon instead. In addition, both the demon and master will inflict 3% more damage. Lasts as long as the demon is active." }
                 } },
                new Talent { TalentName = "Improved Spellstone", ColumnIndex = 2, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "inv_misc_gem_sapphire_01").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the amount of damage absorbed by your Spellstone by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the amount of damage absorbed by your Spellstone by 30%." }
                } }
            };

            var destructionSpec = new List<Talent>
            {
                new Talent { TalentName = "Improved Shadow Bolt", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadowbolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your Shadow Bolt critical strikes increase Shadow damage dealt to the target by 4% until 4 non-periodic damage source are applied. Effect lasts a maximum of 12 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Your Shadow Bolt critical strikes increase Shadow damage dealt to the target by 8% until 4 non-periodic damage source are applied. Effect lasts a maximum of 12 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Your Shadow Bolt critical strikes increase Shadow damage dealt to the target by 12% until 4 non-periodic damage source are applied. Effect lasts a maximum of 12 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Your Shadow Bolt critical strikes increase Shadow damage dealt to the target by 16% until 4 non-periodic damage source are applied. Effect lasts a maximum of 12 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Your Shadow Bolt critical strikes increase Shadow damage dealt to the target by 20% until 4 non-periodic damage source are applied. Effect lasts a maximum of 12 sec." }
                } },
                new Talent { TalentName = "Cataclysm", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_fire_windsofwoe").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Mana cost of your Destruction spells by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Mana cost of your Destruction spells by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the Mana cost of your Destruction spells by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the Mana cost of your Destruction spells by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the Mana cost of your Destruction spells by 5%." }
                } },
                new Talent { TalentName = "Bane", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_shadow_deathpact").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Shadow Bolt and Immolate spells by 0.1 sec and your Soul Fire spell by 0.4 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Shadow Bolt and Immolate spells by 0.2 sec and your Soul Fire spell by 0.8 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the casting time of your Shadow Bolt and Immolate spells by 0.3 sec and your Soul Fire spell by 1.2 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the casting time of your Shadow Bolt and Immolate spells by 0.4 sec and your Soul Fire spell by 1.6 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the casting time of your Shadow Bolt and Immolate spells by 0.5 sec and your Soul Fire spell by 2 sec." }
                } },
                new Talent { TalentName = "Aftermath", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_fire_fire").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Destruction spells a 2% chance to daze the target for 5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Destruction spells a 4% chance to daze the target for 5 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Destruction spells a 6% chance to daze the target for 5 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Destruction spells a 8% chance to daze the target for 5 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Destruction spells a 10% chance to daze the target for 5 sec." }
                } },
                new Talent { TalentName = "Improved Firebolt", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_fire_firebolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Imp's Firebolt spell by 0.5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Imp's Firebolt spell by 1 sec." }
                } },
                new Talent { TalentName = "Improved Lash of Pain", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_curse").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Succubus' Lash of Pain spell by 3 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Succubus' Lash of Pain spell by 3 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cooldown of your Succubus' Lash of Pain spell by 3 sec." }
                } },
                new Talent { TalentName = "Devastation", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_fire_flameshock").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Destruction spells by 1%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Destruction spells by 2%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Destruction spells by 3%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike chance of your Destruction spells by 4%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike chance of your Destruction spells by 5%." }
                } },
                new Talent { TalentName = "Shadowburn", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_shadow_scourgebuild").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Instantly blasts the target for 87 to 100 Shadow damage. If the target dies within 5 sec of Shadowburn, and yields experience of honor, the caster gains a Soul Shard." }
                } },
                new Talent { TalentName = "Intensity", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_lavaspawn").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 35% chance to resist interruption caused by damage while channeling the Rain of Fire, Hellfire or Soul Fire spell." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 70% chance to resist interruption caused by damage while channeling the Rain of Fire, Hellfire or Soul Fire spell." }
                } },
                new Talent { TalentName = "Destructive Reach", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_corpseexplode").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your Destruction spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your Destruction spells by 20%." }
                } },
                new Talent { TalentName = "Improved Searing Pain", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_soulburn").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Searing Pain spell by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Searing Pain spell by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Searing Pain spell by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike chance of your Searing Pain spell by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike chance of your Searing Pain spell by 10%." }
                } },
                new Talent { TalentName = "Pyroclasm", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_fire_volcano").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Rain of Fire, Hellfire, and Soul Fire spells a 26% chance to stun the target for 3 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Rain of Fire, Hellfire, and Soul Fire spells a 26% chance to stun the target for 3 sec." }
                } },
                new Talent { TalentName = "Improved Immolate", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_fire_immolation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the initial damage of your Immolate spell by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the initial damage of your Immolate spell by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the initial damage of your Immolate spell by 15%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the initial damage of your Immolate spell by 20%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the initial damage of your Immolate spell by 25%." }
                } },
                new Talent { TalentName = "Ruin", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_shadow_shadowwordpain").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike damage bonus of your Destruction spells by 100%." }
                } },
                new Talent { TalentName = "Emberstorm", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_fire_selfdestruct").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Fire spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Fire spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Fire spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Fire spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Fire spells by 10%." }
                } },
                new Talent { TalentName = "Conflagrate", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_fire_fireball").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Ignites a target that is already afflicted by Immolate, dealing 240 to 307 Fire damage and consumong the Immolate spell." }
                } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Affliction", SpecificationIndex = 0, SpecificationIcon = "spell_shadow_deathcoil.jpg", Talents = afflicationSpec },
                new WarcraftClassSpecification { SpecificationName = "Demonology", SpecificationIndex = 1, SpecificationIcon = "spell_shadow_metamorphosis.jpg", Talents = demonologySpec },
                new WarcraftClassSpecification { SpecificationName = "Destruction", SpecificationIndex = 2, SpecificationIcon = "spell_shadow_rainoffire.jpg", Talents = destructionSpec }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var afflictionTalents = wcs[0].Talents;
            var demonologyTalents = wcs[1].Talents;
            var destructionTalents = wcs[2].Talents;

            afflictionTalents.First(t => t.TalentName == "Curse of Exhaustion").RequiredTalent = afflictionTalents.First(t => t.TalentName == "Amplify Curse");
            afflictionTalents.First(t => t.TalentName == "Improved Curse of Exhaustion").RequiredTalent = afflictionTalents.First(t => t.TalentName == "Curse of Exhaustion");
            afflictionTalents.First(t => t.TalentName == "Shadow Mastery").RequiredTalent = afflictionTalents.First(t => t.TalentName == "Siphon Life");

            demonologyTalents.First(t => t.TalentName == "Master Summoner").RequiredTalent = demonologyTalents.First(t => t.TalentName == "Fel Domination");
            demonologyTalents.First(t => t.TalentName == "Master Demonologist").RequiredTalent = demonologyTalents.First(t => t.TalentName == "Unholy Power");
            demonologyTalents.First(t => t.TalentName == "Soul Link").RequiredTalent = demonologyTalents.First(t => t.TalentName == "Demonic Sacrifice");

            destructionTalents.First(t => t.TalentName == "Pyroclasm").RequiredTalent = destructionTalents.First(t => t.TalentName == "Intensity");
            destructionTalents.First(t => t.TalentName == "Ruin").RequiredTalent = destructionTalents.First(t => t.TalentName == "Devastation");
            destructionTalents.First(t => t.TalentName == "Conflagrate").RequiredTalent = destructionTalents.First(t => t.TalentName == "Improved Immolate");
        }
    }
}
