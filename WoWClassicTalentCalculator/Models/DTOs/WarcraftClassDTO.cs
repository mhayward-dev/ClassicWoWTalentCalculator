using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWClassicTalentCalculator.Models.DTOs
{
    public class WarcraftClassDTO
    {
        public int WarcraftClassId { get; set; }
        public string ClassName { get; set; }

        public static WarcraftClassDTO ToDTO(WarcraftClass wc)
        {
            return new WarcraftClassDTO {
                WarcraftClassId = wc.WarcraftClassId,
                ClassName = wc.ClassName
            };
        }
    }
}
