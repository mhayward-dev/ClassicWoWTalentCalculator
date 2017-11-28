using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWClassicTalentCalculator.Models
{
    public class Talent
    {
        public int TalentId { get; set; }
        public string TalentName { get; set; }
        public string TalentDescription { get; set; }
        public int NoOfRanks { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public int WarcraftClassSpecificationId { get; set; }
    }
}
