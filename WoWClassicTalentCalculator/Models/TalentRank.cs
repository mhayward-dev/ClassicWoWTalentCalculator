using System.Collections.Generic;

namespace WoWClassicTalentCalculator.Models
{
    public class TalentRank
    {
        public int Id { get; set; }
        public int TalentId { get; set; }
        public string RankDescription { get; set; }
        public int RankNo { get; set; }
    }
}
