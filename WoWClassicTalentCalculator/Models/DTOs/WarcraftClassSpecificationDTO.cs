using System.Collections.Generic;
using System.Linq;

namespace WoWClassicTalentCalculator.Models.DTOs
{
    public class WarcraftClassSpecificationDTO
    {
        public int Id { get; set; }
        public string SpecificationName { get; set; }
        public int WarcraftClassId { get; set; }
        public int SpecificationIndex { get; set; }
        public IEnumerable<SpecificationTalentDTO> SpecificationTalents { get; set; }

        public static WarcraftClassSpecificationDTO ToDTO(WarcraftClassSpecification wcs)
        {
            return new WarcraftClassSpecificationDTO
            {
                Id = wcs.Id,
                SpecificationName = wcs.SpecificationName,
                WarcraftClassId = wcs.WarcraftClassId,
                SpecificationIndex = wcs.SpecificationIndex,
                SpecificationTalents = wcs.SpecificationTalents?.Select(st => SpecificationTalentDTO.ToDTO(st))
            };
        }
    }
}
