using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWClassicTalentCalculator.Models.DTOs
{
    public class TalentRankDTO
    {
        public int Id { get; set; }
        public string RankDescription { get; set; }
        public int RankNo { get; set; }

        public static TalentRankDTO ToDTO(TalentRank tr)
        {
            return new TalentRankDTO
            {
                Id = tr.Id,
                RankDescription = tr.RankDescription,
                RankNo = tr.RankNo
            };
        }
    }
}
