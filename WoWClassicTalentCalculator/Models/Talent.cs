using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WoWClassicTalentCalculator.Models
{
    public class Talent
    {
        public int Id { get; set; }
        [Required]
        public int WarcraftClassSpecificationId { get; set; }
        public string TalentName { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int? TalentIconId { get; set; }
        public TalentIcon TalentIcon { get; set; }
        public TalentRequirement TalentRequirement { get; set; }
        public List<TalentRank> TalentRanks { get; set; }
    }
}
