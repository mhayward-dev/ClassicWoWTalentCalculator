using WoWClassicNews.Models.Enums;
using Frameworks.Extensions;

namespace WoWClassicNews.Models.DTOs
{
    public class RequiredTalentDTO : TalentDTO
    {
        public string RequiredTalentMessage { get; set; }
        public string ArrowDirection { get; set; }

        public new static RequiredTalentDTO ToDTO (Talent t)
        {
            return new RequiredTalentDTO {
                Id = t.RequiredTalent.Id,
                ColumnIndex = t.RequiredTalent.ColumnIndex,
                RowIndex = t.RequiredTalent.RowIndex,
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
