using VanillaReborn.Models.Enums;

namespace VanillaReborn.Models.DTOs
{
    public class TalentRequirementDTO
    {
        public int Id { get; set; }
        public int TalentId { get; set; }
        public int RequiredTalentId { get; set; }
        public int RequiredTalentColumnIndex { get; set; }
        public int RequiredTalentRowIndex { get; set; }
        public string RequiredTalentMessage { get; set; }

        public static TalentRequirementDTO ToDTO (TalentRequirement tr)
        {
            return new TalentRequirementDTO {
                Id = tr.Id,
                TalentId = tr.TalentId,
                RequiredTalentId = tr.RequiredTalentId,
                RequiredTalentColumnIndex = tr.RequiredTalent.ColumnIndex,
                RequiredTalentRowIndex = tr.RequiredTalent.RowIndex,
                RequiredTalentMessage = FormatRequirementMessage(tr.RequiredTalent)
            };
        }

        public static string FormatRequirementMessage(Talent reqTalent)
        {
            var rankCount = reqTalent.TalentRanks?.Count ?? 1;

            return $"Requires { rankCount } point{ (rankCount > 1 ? "s" : "") } in { reqTalent.TalentName }";
        }
    }
}
