using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WoWClassicTalentCalculator.DataAccess.Repositories;
using WoWClassicTalentCalculator.DataAccess;
using Frameworks.Extensions;
using WoWClassicTalentCalculator.Models.DTOs;

namespace WoWClassicTalentCalculator.Controllers.API
{
    [Route("api/Classes")]
    public class WarcraftClassController : Controller
    {
        private readonly TalentCalculatorContext _context;
        private WarcraftClassRepository classRepository;

        public WarcraftClassController(TalentCalculatorContext context)
        {
            _context = context;
            classRepository = new WarcraftClassRepository(context);
        }

        public object GetWarcraftClasses()
        {
            var allClasses = classRepository.All().Results();

            if (allClasses.IsNotNull())
            {
                return Ok(allClasses.Select(wc => WarcraftClassDTO.ToDTO(wc)));
            }

            return BadRequest();
        }
    }
}
