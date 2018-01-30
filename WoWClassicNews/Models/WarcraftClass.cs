using System.Collections.Generic;

namespace WoWClassicNews.Models
{
    public class WarcraftClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int Order { get; set; }
        public List<WarcraftClassSpecification> WarcraftClassSpecifications { get; set; }
    }
}
