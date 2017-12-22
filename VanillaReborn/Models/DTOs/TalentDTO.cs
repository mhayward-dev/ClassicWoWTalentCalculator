using Frameworks.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace VanillaReborn.Models.DTOs
{
    public class TalentDTO
    {
        public int Id { get; set; }
        public string TalentName { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int WarcraftClassSpecificationId { get; set; }
        public string IconFilePath { get; set; }

        public TalentRequirementDTO TalentRequirement { get; set; }
        public IEnumerable<TalentRankDTO> TalentRanks { get; set; }

        public static TalentDTO ToDTO(Talent t)
        {
            return new TalentDTO
            {
                Id = t.Id,
                WarcraftClassSpecificationId = t.WarcraftClassSpecificationId,
                TalentName = t.TalentName,
                ColumnIndex = t.ColumnIndex,
                RowIndex = t.RowIndex,
                IconFilePath = FormatImageUrl(t.TalentIcon?.FileName ?? "inv_misc_questionmark.jpg"),
                TalentRanks = t.TalentRanks.OrderBy(tr => tr.RankNo).Select(tr => TalentRankDTO.ToDTO(tr)),
                TalentRequirement = t.RequiredTalent.IsNotNull() ? TalentRequirementDTO.ToDTO(t) : null
            };
        }

        public static string FormatImageUrl(string fileName)
        {
            return $"images/talent/{ fileName }.jpg";
        }

    }
}
