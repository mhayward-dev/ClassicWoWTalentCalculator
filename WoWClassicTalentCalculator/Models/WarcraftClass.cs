using System.Collections.Generic;

namespace WoWClassicTalentCalculator.Models
{
    public class WarcraftClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int Order { get; set; }
        public List<WarcraftClassSpecification> WarcraftClassSpecifications { get; set; }
    }
}
