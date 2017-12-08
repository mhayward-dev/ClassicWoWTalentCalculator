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
        public string bgImageFilePath { get; set; }
        public List<TalentDTO[]> TalentRows { get; set; }

        public static WarcraftClassSpecificationDTO ToDTO(WarcraftClassSpecification wcs, string className)
        {
            var talentRows = new List<TalentDTO[]>();

            if (wcs.Talents.HasItems())
            {
                for (var i = 0; i <= wcs.Talents.Max(st => st.RowIndex); i++)
                {
                    var talents = wcs.Talents.Where(st => st.RowIndex == i)
                                                          .Select(st => TalentDTO.ToDTO(st))
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
                bgImageFilePath = $"images/spec/{className}_{wcs.SpecificationName.Replace(" ", "")}_bg.jpg",
                TalentRows = talentRows
            };
        }
    }
}
