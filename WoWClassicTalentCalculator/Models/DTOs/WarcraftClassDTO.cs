using Frameworks.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWClassicTalentCalculator.Models.DTOs
{
    public class WarcraftClassDTO
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string IconFilePath { get; set; }
        public IEnumerable<WarcraftClassSpecificationDTO> Specifications { get; set; }

        public static WarcraftClassDTO ToDTO(WarcraftClass wc)
        {
            return new WarcraftClassDTO {
                Id = wc.Id,
                ClassName = wc.ClassName,
                IconFilePath = $"images/class/{ wc.ClassName.ToLower() }_classicon.png",
                Specifications = wc.WarcraftClassSpecifications?.OrderBy(wcs => wcs.SpecificationIndex).Select(wcs => WarcraftClassSpecificationDTO.ToDTO(wcs, wc.ClassName))
            };
        }
    }
}
