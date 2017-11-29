using System.Collections.Generic;

namespace WoWClassicTalentCalculator.Models
{
    public class WarcraftClassSpecification
    {
        public int Id { get; set; }
        public int WarcraftClassId { get; set; }
        public string SpecificationName { get; set; }
        public int SpecificationIndex { get; set; }
        public List<SpecificationTalent> SpecificationTalents { get; set; }
    }
}
