using System.Collections.Generic;

namespace WoWClassicTalentCalculator.Models
{
    public class SpecificationTalent
    {
        public int Id { get; set; }
        public int WarcraftClassSpecificationId { get; set; }
        public string TalentName { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int? TalentIconId { get; set; }
        public List<TalentRank> TalentRanks { get; set; }
        public TalentIcon TalentIcon { get; set; }
    }
}
