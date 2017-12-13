namespace VanillaReborn.Models
{
    public class TalentRequirement
    {
        public int Id { get; set; }
        public int TalentId { get; set; }
        public int RequiredTalentId { get; set; }
        public Talent RequiredTalent { get; set; }
        public int ClassId { get; set; }
    }
}
