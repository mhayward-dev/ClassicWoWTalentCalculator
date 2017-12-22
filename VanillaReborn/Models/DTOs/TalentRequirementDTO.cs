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
        public int ArrowDirection { get; set; }

        public static TalentRequirementDTO ToDTO (TalentRequirement tr, Talent t)
        {
            return new TalentRequirementDTO {
                Id = tr.Id,
                TalentId = tr.TalentId,
                RequiredTalentId = tr.RequiredTalentId,
                RequiredTalentColumnIndex = tr.RequiredTalent.ColumnIndex,
                RequiredTalentRowIndex = tr.RequiredTalent.RowIndex,
                RequiredTalentMessage = FormatRequirementMessage(tr.RequiredTalent),
                ArrowDirection = GetArrowDirection(tr.RequiredTalent, t)
            };
        }

        public static string FormatRequirementMessage(Talent reqTalent)
        {
            var rankCount = reqTalent.TalentRanks?.Count ?? 1;

            return $"Requires { rankCount } point{ (rankCount > 1 ? "s" : "") } in { reqTalent.TalentName }";
        }

        public static int GetArrowDirection(Talent reqTalent, Talent t)
        {
            if (reqTalent.ColumnIndex == t.ColumnIndex)
                return (int)RequirementArrowDirections.Down;

            if (reqTalent.RowIndex == t.RowIndex)
                return (int)RequirementArrowDirections.Right;

            return (int)RequirementArrowDirections.DownRight;
        }
    }
}
