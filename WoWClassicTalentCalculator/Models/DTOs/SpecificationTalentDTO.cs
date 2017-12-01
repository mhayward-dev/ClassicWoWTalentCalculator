using System.Collections.Generic;

namespace WoWClassicTalentCalculator.Models.DTOs
{
    public class SpecificationTalentDTO
    {
        public int Id { get; set; }
        public string TalentName { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int WarcraftClassSpecificationId { get; set; }
        public string IconFilePath { get; set; }
        public IEnumerable<TalentRankDTO> TalentRanks { get; set; }

        public static SpecificationTalentDTO ToDTO(SpecificationTalent st)
        {
            return new SpecificationTalentDTO
            {
                Id = st.Id,
                WarcraftClassSpecificationId = st.WarcraftClassSpecificationId,
                TalentName = st.TalentName,
                ColumnIndex = st.ColumnIndex,
                RowIndex = st.RowIndex,
                IconFilePath = MakeImageUrl(st.TalentIcon?.FileName ?? "inv_misc_questionmark.jpg"),
                TalentRanks = null
            };
        }

        public static string MakeImageUrl(string fileName)
        {
            return $"images/talent/{ fileName }.jpg";
        }
    }
}
