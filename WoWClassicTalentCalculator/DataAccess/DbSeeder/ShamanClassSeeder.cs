using System.Collections.Generic;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.DbSeeder
{
    public static class ShamanClassSeeder
    {
        public static List<WarcraftClassSpecification> SeedShamanTalents()
        {
            // Elemental Talents
            var elementalTalents = new List<SpecificationTalent>
            {
                new SpecificationTalent { TalentName = "Convection", ColumnIndex = 1, RowIndex = 0,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 2%" },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 4%" },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 6%" },
                        new TalentRank { RankNo = 4, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 8%" },
                        new TalentRank { RankNo = 5, RankDescription = "Reduces the mana cost of your Shock, Lightning Bolt, and Chain Lightning spells by 10%" }
                    } },
                new SpecificationTalent { TalentName = "Concussion", ColumnIndex = 2, RowIndex = 0,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 1%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 2%" },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 3%" },
                        new TalentRank { RankNo = 4, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 4%" },
                        new TalentRank { RankNo = 5, RankDescription = "Increases the damage done by your Lightning Bolt, Chain Lightning, and Shock spells by 5%" }
                } },
                new SpecificationTalent { TalentName = "Earth's Grasp", ColumnIndex = 0, RowIndex = 1,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the health of your Stoneclaw Totem by 25% and the radius of your Earthbind Totem by 10%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the health of your Stoneclaw Totem by 50% and the radius of your Earthbind Totem by 20%" }
                } },
                new SpecificationTalent { TalentName = "Elemental Warding", ColumnIndex = 1, RowIndex = 1,
                     TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Reduces damage taken from Fire, Frost, and Nature effects by 4%" },
                        new TalentRank { RankNo = 2, RankDescription = "Reduces damage taken from Fire, Frost, and Nature effects by 8%" },
                        new TalentRank { RankNo = 3, RankDescription = "Reduces damage taken from Fire, Frost, and Nature effects by 12%" }
                } },
                new SpecificationTalent { TalentName = "Call of Flame", ColumnIndex = 2, RowIndex = 1,
                    TalentRanks = new List<TalentRank> {
                        new TalentRank { RankNo = 1, RankDescription = "Increases the damage done by your Fire Totems by 5%" },
                        new TalentRank { RankNo = 2, RankDescription = "Increases the damage done by your Fire Totems by 10%" },
                        new TalentRank { RankNo = 3, RankDescription = "Increases the damage done by your Fire Totems by 15%" }
                } },
            };

            return new List<WarcraftClassSpecification> {
                new WarcraftClassSpecification { SpecificationName = "Elemental", SpecificationIndex = 0, SpecificationTalents = elementalTalents },
                new WarcraftClassSpecification { SpecificationName = "Enhancement", SpecificationIndex = 1 },
                new WarcraftClassSpecification { SpecificationName = "Restoration", SpecificationIndex = 2 }
            };
        }
    }
}
