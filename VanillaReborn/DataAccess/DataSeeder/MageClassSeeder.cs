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

            var fireTalents = new List<Talent>
            {
                new Talent { TalentName = "Improved Fireball", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_fire_flamebolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Fireball spell by 0.1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Fireball spell by 0.2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the casting time of your Fireball spell by 0.3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the casting time of your Fireball spell by 0.4 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the casting time of your Fireball spell by 0.5 sec." }
                } },
                new Talent { TalentName = "Impact", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_fire_meteorstorm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Fire spells a 2% chance to stun the target for 2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Fire spells a 4% chance to stun the target for 2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Fire spells a 6% chance to stun the target for 2 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Fire spells a 8% chance to stun the target for 2 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Fire spells a 10% chance to stun the target for 2 sec." }
                } },
                new Talent { TalentName = "Ignite", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_fire_incinerate").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your critical strikes from Fire famage spells cause the target to burn for an additional 8% of your spell's damage over 4 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Your critical strikes from Fire famage spells cause the target to burn for an additional 16% of your spell's damage over 4 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Your critical strikes from Fire famage spells cause the target to burn for an additional 24% of your spell's damage over 4 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Your critical strikes from Fire famage spells cause the target to burn for an additional 32% of your spell's damage over 4 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Your critical strikes from Fire famage spells cause the target to burn for an additional 40% of your spell's damage over 4 sec.." }
                } },
                new Talent { TalentName = "Flame Throwing", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_fire_flare").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your Fire spells by 3 yards." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your Fire spells by 6 yards." }
                } },
                new Talent { TalentName = "Improved Fire Blast", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_fire_fireball").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Fire Blast spell by 0.5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Fire Blast spell by 1 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cooldown of your Fire Blast spell by 1.5 sec." }
                } },
                new Talent { TalentName = "Incinerate", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_fire_flameshock").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Fire Blast and Scorch spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Fire Blast and Scorch spells by 2%." },
                } },
                new Talent { TalentName = "Improved Flamestrike", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_fire_selfdestruct").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Flamestrike spell by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Flamestrike spell by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Flamestrike spell by 15%." }
                } },
                new Talent { TalentName = "Pyroblast", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_fire_fireball02").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Hurls an immense fiery boulder that causes 141 to 188 Fire damage and an additional 56 Fire damage over 12 sec." }
                } },
                new Talent { TalentName = "Burning Soul", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_fire_fire").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Fire spells a 70% chance to not lose casting time when you take damage and reduces the threat caused by your Fire spells by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Fire spells a 70% chance to not lose casting time when you take damage and reduces the threat caused by your Fire spells by 30%." }
                } },
                new Talent { TalentName = "Improved Scorch", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_soulburn").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your Scorch spells have a 100% chance to cause your target to be vulnerable to Fire damage. This vulnerability increases the Fire damage dealt to your target by 3% and lasts 30 sec. Stacks up to 30001 times." },
                        new TalentRank { RankNo = 2, RankDescription = "Your Scorch spells have a 100% chance to cause your target to be vulnerable to Fire damage. This vulnerability increases the Fire damage dealt to your target by 3% and lasts 30 sec. Stacks up to 30001 times." },
                        new TalentRank { RankNo = 3, RankDescription = "Your Scorch spells have a 100% chance to cause your target to be vulnerable to Fire damage. This vulnerability increases the Fire damage dealt to your target by 3% and lasts 30 sec. Stacks up to 30001 times." }
                } },
                new Talent { TalentName = "Improved Fire Ward", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_firearmor").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Causes your Fire Ward to have a 10% chance to reflect Fire spells while active." },
                        new TalentRank { RankNo = 2, RankDescription = "Causes your Fire Ward to have a 20% chance to reflect Fire spells while active." }
                } },
                new Talent { TalentName = "Master of Elements", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_fire_masterofelements").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your Fire and Frost spell criticals will refund 10% of their base mana cost." },
                        new TalentRank { RankNo = 2, RankDescription = "Your Fire and Frost spell criticals will refund 20% of their base mana cost." },
                        new TalentRank { RankNo = 3, RankDescription = "Your Fire and Frost spell criticals will refund 30% of their base mana cost." }
                } },
                new Talent { TalentName = "Critical Mass", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_wispheal").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of your Fire spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of your Fire spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of your Fire spells by 6%." }
                } },
                new Talent { TalentName = "Blast Wave", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_holy_excorcism_02").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "A wave of flame radiates outward from the caster, damaging all enemies caught within the blast for 154 to 187 Fire damage, and dazing them for 6 sec." }
                } },
                new Talent { TalentName = "Fire Power", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_fire_immolation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Fire spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Fire spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Fire spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Fire spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Fire spells by 10%." }
                 } },
                new Talent { TalentName = "Combustion", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_fire_sealoffire").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, this spell causes each of your Fire damage spell hits to increase your critical strike chance with Fire damage spells by 10%. This effect lasts until you have caused 3 critical strikes with Fire spells." }
                 } }
            };

            var frostTalents = new List<Talent>
            {
                new Talent { TalentName = "Frost Warding", ColumnIndex = 0, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_frostward").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the armor and resistances given by your Frost Armor and Ice Armor spells by 15%. In addition, gives your Frost Ward a 10% chance to reflect Frost Spells and effects while active." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the armor and resistances given by your Frost Armor and Ice Armor spells by 30%. In addition, gives your Frost Ward a 20% chance to reflect Frost Spells and effects while active." }
                } },
                new Talent { TalentName = "Improved Frostbolt", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_frostbolt02").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the casting time of your Frostbolt spell by 0.1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the casting time of your Frostbolt spell by 0.2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the casting time of your Frostbolt spell by 0.3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the casting time of your Frostbolt spell by 0.4 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the casting time of your Frostbolt spell by 0.5 sec." }
                } },
                new Talent { TalentName = "Elemental Precision", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_frost_iceshard").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the chance that the opponent can resist your Frost and Fire spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the chance that the opponent can resist your Frost and Fire spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the chance that the opponent can resist your Frost and Fire spells by 6%." }
                } },
                new Talent { TalentName = "Ice Shards", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_frost_iceshard").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike damage bonus of your Frost spells by 20%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike damage bonus of your Frost spells by 40%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike damage bonus of your Frost spells by 60%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike damage bonus of your Frost spells by 80%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike damage bonus of your Frost spells by 100%." }
                } },
                new Talent { TalentName = "Frostbite", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_frost_frostarmor").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Chill effects a 5% chance to freeze the target for 5 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Chill effects a 10% chance to freeze the target for 5 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Chill effects a 15% chance to freeze the target for 5 sec." }
                } },
                new Talent { TalentName = "Improved Frost Nova", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_frost_freezingbreath").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cooldown of your Frost Nova sepll by 2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cooldown of your Frost Nova sepll by 4 sec." }
                } },
                new Talent { TalentName = "Permafrost", ColumnIndex = 3, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_frost_wisp").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the duration of your Chill effects by 1 secs and reduces the target's speed by addtional 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the duration of your Chill effects by 2 secs and reduces the target's speed by addtional 7%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the duration of your Chill effects by 3 secs and reduces the target's speed by addtional 10%." }
                } },
                new Talent { TalentName = "Piercing Ice", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_frost_frostbolt").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Frost spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Frost spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Frost spells by 6%." }
                } },
                new Talent { TalentName = "Cold Snap", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_frost_wizardmark").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, this spell finishes the cooldown on all of your Frost spells." }
                } },
                new Talent { TalentName = "Improved Blizzard", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_frost_icestorm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Adds a chill effect to your Blizzard spell. This effect lowers the target's movement speed by 30%. Lasts 2 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Adds a chill effect to your Blizzard spell. This effect lowers the target's movement speed by 50%. Lasts 2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Adds a chill effect to your Blizzard spell. This effect lowers the target's movement speed by 65%. Lasts 2 sec." }
                } },
                new Talent { TalentName = "Arctic Reach", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_darkritual").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the range of your Frostbolt and Blizzard spells and the radius of your Frost Nova and Cone of Cold spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the range of your Frostbolt and Blizzard spells and the radius of your Frost Nova and Cone of Cold spells by 20%." }
                } },
                new Talent { TalentName = "Frost Channeling", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_frost_stun").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the mana cost of your Frost spells by 5% and reduces the threat caused by your Frost spells by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the mana cost of your Frost spells by 10% and reduces the threat caused by your Frost spells by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the mana cost of your Frost spells by 15% and reduces the threat caused by your Frost spells by 30%." }
                } },
                new Talent { TalentName = "Shatter", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_frost_frostshock").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike chance of all your spells against frozen targets by 50%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike chance of all your spells against frozen targets by 50%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike chance of all your spells against frozen targets by 50%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike chance of all your spells against frozen targets by 50%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike chance of all your spells against frozen targets by 50%." }
                } },
                new Talent { TalentName = "Ice Block", ColumnIndex = 1, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_frost_frost").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "You become encased in a block of ice, proteching you from all physical attacks and spells for 10 sec, but during that time you cannot attack, move or cast spells." }
                } },
                new Talent { TalentName = "Improved Cone of Cold", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_frost_glacier").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage dealt by your Cone of Cold spells by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage dealt by your Cone of Cold spells by 25%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage dealt by your Cone of Cold spells by 35%." }
                 } },
                new Talent { TalentName = "Winter's Chill", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_frost_chillingblast").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives your Frost damage spells a 100% chance to apply the Winter's chill effect, which increases the chance a Frost spell will critically hit the target by 2% for 15 sec. Stacks up to 15001 times." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives your Frost damage spells a 100% chance to apply the Winter's chill effect, which increases the chance a Frost spell will critically hit the target by 2% for 15 sec. Stacks up to 15001 times." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives your Frost damage spells a 100% chance to apply the Winter's chill effect, which increases the chance a Frost spell will critically hit the target by 2% for 15 sec. Stacks up to 15001 times." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives your Frost damage spells a 100% chance to apply the Winter's chill effect, which increases the chance a Frost spell will critically hit the target by 2% for 15 sec. Stacks up to 15001 times." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives your Frost damage spells a 100% chance to apply the Winter's chill effect, which increases the chance a Frost spell will critically hit the target by 2% for 15 sec. Stacks up to 15001 times." }
                } },
                new Talent { TalentName = "Ice Barrier", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_ice_lament").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Instantly shield you, absorbing 438 damage. Lasts 1 min. While the shield holds, spells will not be interrupted." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Arcane", SpecificationIndex = 0, SpecificationIcon = "spell_holy_magicalsentry.jpg", Talents = arcaneTalents },
                new WarcraftClassSpecification { SpecificationName = "Fire", SpecificationIndex = 1, SpecificationIcon = "spell_fire_firebolt02.jpg", Talents = fireTalents },
                new WarcraftClassSpecification { SpecificationName = "Frost", SpecificationIndex = 2, SpecificationIcon = "spell_frost_frostbolt02.jpg", Talents = frostTalents }
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

            fireTalents.First(t => t.TalentName == "Blast Wave").RequiredTalent = fireTalents.First(t => t.TalentName == "Pyroblast");
            fireTalents.First(t => t.TalentName == "Combustion").RequiredTalent = fireTalents.First(t => t.TalentName == "Critical Mass");

            frostTalents.First(t => t.TalentName == "Shatter").RequiredTalent = frostTalents.First(t => t.TalentName == "Improved Frost Nova");
            frostTalents.First(t => t.TalentName == "Ice Barrier").RequiredTalent = frostTalents.First(t => t.TalentName == "Ice Block");
        }
    }
}
