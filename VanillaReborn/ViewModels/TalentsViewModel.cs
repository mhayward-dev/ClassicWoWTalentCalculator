using System.Collections.Generic;
using VanillaReborn.Models.DTOs;

namespace VanillaReborn.ViewModels
{
    public class TalentsViewModel
    {
        public WarcraftClassDTO SelectedClass { get; set; }
        public IEnumerable<TalentRequirementDTO> TalentRequirements { get; set; }
    }
}
