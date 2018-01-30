using System.Collections.Generic;
using System.Linq;
using WoWClassicNews.Models;

namespace WoWClassicNews.DataAccess.DataSeeder
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
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage caused by your Thorns spell by 25%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage caused by your Thorns spell by 50%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage caused by your Thorns spell by 75%." }
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
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 20%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 40%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 60%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 80%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical strike damage bonus of your Starfire, Moonfire and Wrath spells by 100%." }
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

            // Feral Combat
            var feralCombatTalents = new List<Talent>
            {
                new Talent { TalentName = "Ferocity", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_hunter_pet_hyena").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cost of your Maul, Swipe, Claw and Rake abilities by 1 Rage or Energy." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cost of your Maul, Swipe, Claw and Rake abilities by 2 Rage or Energy." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cost of your Maul, Swipe, Claw and Rake abilities by 3 Rage or Energy." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the cost of your Maul, Swipe, Claw and Rake abilities by 4 Rage or Energy." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the cost of your Maul, Swipe, Claw and Rake abilities by 5 Rage or Energy." }
                } },
                new Talent { TalentName = "Feral Aggression", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "ability_druid_demoralizingroar").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the Attack Power reduction of your Demoralizing Roar by 8% and the damage caused by your Ferocious Bite by 3%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the Attack Power reduction of your Demoralizing Roar by 16% and the damage caused by your Ferocious Bite by 6%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the Attack Power reduction of your Demoralizing Roar by 24% and the damage caused by your Ferocious Bite by 9%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the Attack Power reduction of your Demoralizing Roar by 32% and the damage caused by your Ferocious Bite by 12%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the Attack Power reduction of your Demoralizing Roar by 40% and the damage caused by your Ferocious Bite by 15%." }
                    } },
                new Talent { TalentName = "Feral Instinct", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_ambush").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 15%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 30%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 45%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the chance for your Nature's Grasp to entangle an enemy by 65%." }
                } },
                new Talent { TalentName = "Brutal Impact", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_stranglevines").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the stun duration of your Bash and Pounce abilities by 0.5 sec" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the stun duration of your Bash and Pounce abilities by 1 sec" }
                } },
                new Talent { TalentName = "Thick Hide", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "inv_misc_pelt_bear_03").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Armour contribution from items by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Armour contribution from items by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Armour contribution from items by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Armour contribution from items by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Armour contribution from items by 10%." }
                } },
                new Talent { TalentName = "Feline Swiftness", ColumnIndex = 0, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_spiritwolf").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your movement speed by 15% while outdoors in Cat Form and increases your chance to dodge in while in Cat Form by 2%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your movement speed by 30% while outdoors in Cat Form and increases your chance to dodge in while in Cat Form by 4%" }
                } },
                new Talent { TalentName = "Feral Charge", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_hunter_pet_bear").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Causes you to charge an enemy, immobilizing and interrupting any spell cast for 4 sec." }
                } },
                new Talent { TalentName = "Sharpened Claws", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "inv_misc_monsterclaw_04").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your critical strike chance while in Bear, Dire Bear and Cat Form by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your critical strike chance while in Bear, Dire Bear and Cat Form by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your critical strike chance while in Bear, Dire Bear and Cat Form by 6%." }
                } },
                new Talent { TalentName = "Improved Shred", ColumnIndex = 0, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_shadow_vampiricaura").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the Energy cost of your Shred ability by 6." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the Energy cost of your Shred ability by 12." }
                } },
                new Talent { TalentName = "Predatory Strikes", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_hunter_pet_cat").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your melee attack power in Cat, Bear and Dire Bear forms by 50% of your level." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your melee attack power in Cat, Bear and Dire Bear forms by 100% of your level." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your melee attack power in Cat, Bear and Dire Bear forms by 150% of your level." }
                } },
                new Talent { TalentName = "Blood Frenzy", ColumnIndex = 2, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_ghoulfrenzy").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Your critical strikes from Cat Form abilities that add combo points have a 50% chance to add an additional combo point." },
                        new TalentRank { RankNo = 2, RankDescription = "Your critical strikes from Cat Form abilities that add combo points have a 100% chance to add an additional combo point." }
                } },
                new Talent { TalentName = "Primal Fury", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "ability_racial_cannibalize").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 50% chance to gain an addtional 5 Rage anytime you get a critical strike while in Bear and Dire Bear Form." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 100% chance to gain an addtional 5 Rage anytime you get a critical strike while in Bear and Dire Bear Form." }
                } },
                new Talent { TalentName = "Savage Fury", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "ability_druid_ravage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage caused by your Claw, Rake, Swipe and Maul abilities by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage caused by your Claw, Rake, Swipe and Maul abilities by 20%." }
                } },
                new Talent { TalentName = "Faerie Fire (Feral)", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_faeriefire").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Decrease the armour of the target by 175 for 40 sec. While affected, the enemy cannot stealth or turn invisible." }
                } },
                new Talent { TalentName = "Heart of the Wild", ColumnIndex = 1, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofagility").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases your Intellect by 4%. In addition, while in Bear or Dire Bear Form your Stamina is increased by 4% and while in Cat Form your Strength is increased by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases your Intellect by 8%. In addition, while in Bear or Dire Bear Form your Stamina is increased by 8% and while in Cat Form your Strength is increased by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases your Intellect by 12%. In addition, while in Bear or Dire Bear Form your Stamina is increased by 12% and while in Cat Form your Strength is increased by 12%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases your Intellect by 16%. In addition, while in Bear or Dire Bear Form your Stamina is increased by 16% and while in Cat Form your Strength is increased by 16%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases your Intellect by 20%. In addition, while in Bear or Dire Bear Form your Stamina is increased by 20% and while in Cat Form your Strength is increased by 20%." }
                 } },
                new Talent { TalentName = "Leader of the Pack", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "spell_nature_unyeildingstamina").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "While in Cat, Bear or Dire Bear Form, the Leader of the Pack increases ranged and melee critical strike chance of all party members within 45 yards by 3%." }
                 } }
            };

            // Restoration
            var restorationTalents = new List<Talent>
            {
                new Talent { TalentName = "Improved Mark of the Wild", ColumnIndex = 1, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_nature_regeneration").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effects of your Mark of the Wild and Gift of the Wild spells by 14%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effects of your Mark of the Wild and Gift of the Wild spells by 21%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effects of your Mark of the Wild and Gift of the Wild spells by 28%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the effects of your Mark of the Wild and Gift of the Wild spells by 35%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the effects of your Mark of the Wild and Gift of the Wild spells by 42%." }
                } },
                new Talent { TalentName = "Furor", ColumnIndex = 2, RowIndex = 0, TalentIconId = icons.First(i => i.FileName == "spell_holy_blessingofstamina").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 20% chance to gain 10 Rage when you shapeshift into Bear and Dire Bear Form or 40 Energy when you shapeshift into Cat Form." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 40% chance to gain 10 Rage when you shapeshift into Bear and Dire Bear Form or 40 Energy when you shapeshift into Cat Form." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 60% chance to gain 10 Rage when you shapeshift into Bear and Dire Bear Form or 40 Energy when you shapeshift into Cat Form." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 80% chance to gain 10 Rage when you shapeshift into Bear and Dire Bear Form or 40 Energy when you shapeshift into Cat Form." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 100% chance to gain 10 Rage when you shapeshift into Bear and Dire Bear Form or 40 Energy when you shapeshift into Cat Form." }
                    } },
                new Talent { TalentName = "Improved Healing Touch", ColumnIndex = 0, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_healingtouch").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the cast time of your Healing Touch spell by 0.1 sec." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the cast time of your Healing Touch spell by 0.2 sec." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the cast time of your Healing Touch spell by 0.3 sec." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the cast time of your Healing Touch spell by 0.4 sec." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the cast time of your Healing Touch spell by 0.5 sec." }
                } },
                new Talent { TalentName = "Nature's Focus", ColumnIndex = 1, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "spell_nature_healingwavegreater").Id,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while casting the Healing Touch, Regrowth and Tranquility spells." },
                        new TalentRank { RankNo = 2, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while casting the Healing Touch, Regrowth and Tranquility spells." },
                        new TalentRank { RankNo = 3, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while casting the Healing Touch, Regrowth and Tranquility spells." },
                        new TalentRank { RankNo = 4, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while casting the Healing Touch, Regrowth and Tranquility spells." },
                        new TalentRank { RankNo = 5, RankDescription = "Gives you a 14% chance to avoid interruption caused by damage while casting the Healing Touch, Regrowth and Tranquility spells." }
                } },
                new Talent { TalentName = "Improved Rage", ColumnIndex = 2, RowIndex = 1, TalentIconId = icons.First(i => i.FileName == "ability_druid_enrage").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "The Enrage ability now generates 5 Rage." },
                        new TalentRank { RankNo = 2, RankDescription = "The Enrage ability now generates 10 Rage." }
                } },
                new Talent { TalentName = "Reflection", ColumnIndex = 1, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_frost_windwalkon").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Allows 5% of your Mana regeneration to continue while casting." },
                        new TalentRank { RankNo = 2, RankDescription = "Allows 10% of your Mana regeneration to continue while casting." },
                        new TalentRank { RankNo = 3, RankDescription = "Allows 15% of your Mana regeneration to continue while casting." }
                } },
                new Talent { TalentName = "Insect Swarm", ColumnIndex = 2, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "spell_nature_insectswarm").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "The enemy target is swarmed by insects, decreasing their chance to hit by 2% and causing 66 Nature damage over 12 sec." }
                } },
                new Talent { TalentName = "Subtlety", ColumnIndex = 3, RowIndex = 2, TalentIconId = icons.First(i => i.FileName == "ability_eyeoftheowl").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the threat generated by your Healing spells by 4%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the threat generated by your Healing spells by 8%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the threat generated by your Healing spells by 12%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the threat generated by your Healing spells by 16%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the threat generated by your Healing spells by 20%." }
                } },
                new Talent { TalentName = "Tranquil Spirit", ColumnIndex = 1, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_holy_elunesgrace").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the mana cost of Healing Touch and Tranquility spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the mana cost of Healing Touch and Tranquility spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the mana cost of Healing Touch and Tranquility spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the mana cost of Healing Touch and Tranquility spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the mana cost of Healing Touch and Tranquility spells by 10%." }
                } },
                new Talent { TalentName = "Improved Rejuvenation", ColumnIndex = 3, RowIndex = 3, TalentIconId = icons.First(i => i.FileName == "spell_nature_rejuvenation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of your Rejuvenation spell by 5%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of your Rejuvenation spell by 10%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of your Rejuvenation spell by 15%." }
                } },
                new Talent { TalentName = "Nature's Swiftness", ColumnIndex = 0, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_ravenform").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "When activated, your next Nature spell becomes an instant cast spell." }
                } },
                new Talent { TalentName = "Gift of Nature", ColumnIndex = 2, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_protectionformnature").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the effect of all healing spells by 2%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the effect of all healing spells by 4%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the effect of all healing spells by 6%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the effect of all healing spells by 8%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the effect of all healing spells by 10%." }
                } },
                new Talent { TalentName = "Improved Tranquility", ColumnIndex = 3, RowIndex = 4, TalentIconId = icons.First(i => i.FileName == "spell_nature_tranquility").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces threat caused by Tranquility by 50%." },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces threat caused by Tranquility by 100%." }
                } },
                new Talent { TalentName = "Improved Regrowth", ColumnIndex = 2, RowIndex = 5, TalentIconId = icons.First(i => i.FileName == "spell_nature_resistnature").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the critical effect chance of your Regrowth spell by 10%." },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the critical effect chance of your Regrowth spell by 20%." },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the critical effect chance of your Regrowth spell by 30%." },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the critical effect chance of your Regrowth spell by 40%." },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the critical effect chance of your Regrowth spell by 50%." }
                } },
                new Talent { TalentName = "Swiftmend", ColumnIndex = 1, RowIndex = 6, TalentIconId = icons.First(i => i.FileName == "inv_relics_idolofrejuvenation").Id,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Consumes a Rejuvenation or Regrowth effect on a friendly target to instant heal them an amount equal to 12 sec. of Rejuvenation or 18 sec. of Regrowth." }
                 } }
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Balance", SpecificationIndex = 0, SpecificationIcon = "spell_nature_starfall.jpg", Talents = balanceTalents },
                new WarcraftClassSpecification { SpecificationName = "Feral Combat", SpecificationIndex = 1, SpecificationIcon = "ability_racial_bearform.jpg", Talents = feralCombatTalents },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2, SpecificationIcon = "spell_nature_healingtouch.jpg", Talents = restorationTalents }
            };
        }

        public static void SetupTalentRequirements(List<WarcraftClassSpecification> wcs)
        {
            var balanceTalents = wcs[0].Talents;
            var feralTalents = wcs[1].Talents;
            var restorationTalents = wcs[2].Talents;

            balanceTalents.First(t => t.TalentName == "Improved Nature's Grasp").RequiredTalent = balanceTalents.First(t => t.TalentName == "Nature's Grasp");
            balanceTalents.First(t => t.TalentName == "Vengeance").RequiredTalent = balanceTalents.First(t => t.TalentName == "Improved Moonfire");
            balanceTalents.First(t => t.TalentName == "Omen of Clarity").RequiredTalent = balanceTalents.First(t => t.TalentName == "Natural Weapons");
            balanceTalents.First(t => t.TalentName == "Moonfury").RequiredTalent = balanceTalents.First(t => t.TalentName == "Nature's Grace");

            feralTalents.First(t => t.TalentName == "Blood Frenzy").RequiredTalent = feralTalents.First(t => t.TalentName == "Sharpened Claws");
            feralTalents.First(t => t.TalentName == "Primal Fury").RequiredTalent = feralTalents.First(t => t.TalentName == "Sharpened Claws");
            feralTalents.First(t => t.TalentName == "Heart of the Wild").RequiredTalent = feralTalents.First(t => t.TalentName == "Predatory Strikes");

            restorationTalents.First(t => t.TalentName == "Nature's Swiftness").RequiredTalent = restorationTalents.First(t => t.TalentName == "Improved Healing Touch");
            restorationTalents.First(t => t.TalentName == "Gift of Nature").RequiredTalent = restorationTalents.First(t => t.TalentName == "Insect Swarm");
            restorationTalents.First(t => t.TalentName == "Swiftmend").RequiredTalent = restorationTalents.First(t => t.TalentName == "Tranquil Spirit");
        }
    }
}
