using VanillaReborn.Models.Enums;
using Frameworks.Extensions;

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
        public string ArrowDirection { get; set; }

        public static TalentRequirementDTO ToDTO (Talent t)
        {
            return new TalentRequirementDTO {
                RequiredTalentId = t.RequiredTalent.Id,
                RequiredTalentColumnIndex = t.RequiredTalent.ColumnIndex,
                RequiredTalentRowIndex = t.RequiredTalent.RowIndex,
                RequiredTalentMessage = FormatRequirementMessage(t.RequiredTalent),
                ArrowDirection = GetArrowDirection(t)
            };
        }

        public static string FormatRequirementMessage(Talent reqTalent)
        {
            var rankCount = reqTalent.TalentRanks?.Count ?? 1;

            return $"Requires { rankCount } point{ (rankCount > 1 ? "s" : "") } in { reqTalent.TalentName }";
        }

        public static string GetArrowDirection(Talent t)
        {
            var direction = RequirementArrowDirections.DownRight;

            if (t.RequiredTalent.ColumnIndex == t.ColumnIndex)
                direction = RequirementArrowDirections.Down;

            if (t.RequiredTalent.RowIndex == t.RowIndex)
                direction = RequirementArrowDirections.Right;

            return direction.FormattedName();
        }
    }
}
