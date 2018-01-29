using System.Collections.Generic;
using System.Linq;
using VanillaReborn.Models.Enums;
using Frameworks.Extensions;

namespace VanillaReborn.Models.DTOs
{
    public class TalentCalculatorDTO
    {
        public WarcraftClassDTO SelectedClass { get; set; }
        public int TotalTalentCount { get; set; }

        public static TalentCalculatorDTO ToDTO(WarcraftClass wc)
        {
            var totalTalentCount = 0;
            wc.WarcraftClassSpecifications?.ForEach(wcs => totalTalentCount += wcs.Talents.Count());

            return new TalentCalculatorDTO
            {
                SelectedClass = WarcraftClassDTO.ToDTO(wc),
                TotalTalentCount = totalTalentCount
            };
        }
    }
}
