namespace WoWClassicTalentCalculator.Models.DTOs
{
    public class SpecificationTalentDTO
    {
        public int Id { get; set; }
        public string TalentName { get; set; }
        public string TalentDescription { get; set; }
        public int NoOfRanks { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int WarcraftClassSpecificationId { get; set; }

        public static SpecificationTalentDTO ToDTO(SpecificationTalent st)
        {
            return new SpecificationTalentDTO
            {
                Id = st.Id,
                TalentName = st.TalentName,
                TalentDescription = st.TalentDescription,
                NoOfRanks = st.NoOfRanks,
                ColumnIndex = st.ColumnIndex,
                RowIndex = st.RowIndex,
                WarcraftClassSpecificationId = st.WarcraftClassSpecificationId
            };
        }
    }
}
