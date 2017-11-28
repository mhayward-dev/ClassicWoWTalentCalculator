namespace WoWClassicTalentCalculator.Models
{
    public class SpecificationTalent
    {
        public int Id { get; set; }
        public string TalentName { get; set; }
        public string TalentDescription { get; set; }
        public int NoOfRanks { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int WarcraftClassSpecificationId { get; set; }
    }
}
