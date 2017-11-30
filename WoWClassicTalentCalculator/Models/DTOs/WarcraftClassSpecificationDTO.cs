using Frameworks.Extensions;
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
        public List<SpecificationTalentDTO[]> TalentRows { get; set; }

        public static WarcraftClassSpecificationDTO ToDTO(WarcraftClassSpecification wcs)
        {
            var talentRows = new List<SpecificationTalentDTO[]>();

            if (wcs.SpecificationTalents.HasItems())
            {
                for (var i = 0; i <= wcs.SpecificationTalents.Max(st => st.RowIndex); i++)
                {
                    var talents = wcs.SpecificationTalents.Where(st => st.RowIndex == i)
                                                          .Select(st => SpecificationTalentDTO.ToDTO(st))
                                                          .ToArray();
                    talentRows.Add(talents);
                }
            }

            return new WarcraftClassSpecificationDTO
            {
                Id = wcs.Id,
                SpecificationName = wcs.SpecificationName,
                WarcraftClassId = wcs.WarcraftClassId,
                SpecificationIndex = wcs.SpecificationIndex,
                TalentRows = talentRows
            };
        }
    }
}
