using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWClassicTalentCalculator.Models
{
    public class WarcraftClassSpecification
    {
        public int WarcraftClassSpecificationId { get; set; }
        public string SpecificationName { get; set; }
        public int WarcraftClassId { get; set; }
        public int SpecificationIndex { get; set; }
        public List<Talent> Talents { get; set; }
    }
}
