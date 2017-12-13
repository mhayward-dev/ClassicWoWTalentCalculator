using Frameworks.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanillaReborn.Models.DTOs
{
    public class WarcraftClassDTO
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string IconFilePath { get; set; }
        public IEnumerable<WarcraftClassSpecificationDTO> Specifications { get; set; }
        public int TotalTalentCount { get; set; }

        public static WarcraftClassDTO ToDTO(WarcraftClass wc)
        {
            var totalTalentCount = 0;
            wc.WarcraftClassSpecifications?.ForEach(wcs => totalTalentCount += wcs.Talents.Count());

            return new WarcraftClassDTO {
                Id = wc.Id,
                ClassName = wc.ClassName,
                IconFilePath = $"images/class/{ wc.ClassName.ToLower() }_classicon.png",
                Specifications = wc.WarcraftClassSpecifications?.OrderBy(wcs => wcs.SpecificationIndex).Select(wcs => WarcraftClassSpecificationDTO.ToDTO(wcs, wc.ClassName)),
                TotalTalentCount = totalTalentCount
            };
        }
    }
}
