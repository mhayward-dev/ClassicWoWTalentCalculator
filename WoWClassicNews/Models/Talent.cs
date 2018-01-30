using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WoWClassicNews.Models
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
        public int? RequiredTalentId { get; set; }
        public Talent RequiredTalent { get; set; }
        public List<TalentRank> TalentRanks { get; set; }
    }
}
