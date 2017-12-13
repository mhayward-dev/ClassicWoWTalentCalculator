using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VanillaReborn.DataAccess.Repositories;
using VanillaReborn.DataAccess;
using Frameworks.Extensions;
using VanillaReborn.Models.DTOs;
using VanillaReborn.ViewModels;

namespace VanillaReborn.Controllers.API
{
    [Route("api/Classes")]
    public class WarcraftClassController : Controller
    {
        private readonly VanillaRebornContext _context;
        private WarcraftClassRepository classRepository;

        public WarcraftClassController(VanillaRebornContext context)
        {
            _context = context;
            classRepository = new WarcraftClassRepository(context);
        }

        public object GetWarcraftClasses()
        {
            var allClasses = classRepository.All().SelectResults(wc => WarcraftClassDTO.ToDTO(wc));

            if (allClasses.IsNotNull())
            {
                return Ok(allClasses);
            }

            return BadRequest();
        }

        [Route("{className}")]
        public object GetSelectedSpecificationsForClass(string className)
        {
            var warcraftClass = classRepository.All()
                                               .EagerLoad()
                                               .ForClassName(className)
                                               .FirstResult();

            if (warcraftClass.IsNotNull())
            {
                return Ok(WarcraftClassDTO.ToDTO(warcraftClass));
            }

            return BadRequest();
        }
    }
}
