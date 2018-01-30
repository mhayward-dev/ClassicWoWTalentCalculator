using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WoWClassicNews.DataAccess.Repositories;
using WoWClassicNews.DataAccess;
using Frameworks.Extensions;
using WoWClassicNews.Models.DTOs;
using WoWClassicNews.ViewModels;

namespace WoWClassicNews.Controllers.API
{
    [Route("api/Classes")]
    public class WarcraftClassController : Controller
    {
        private readonly WoWClassicNewsContext _context;
        private WarcraftClassRepository classRepository;

        public WarcraftClassController(WoWClassicNewsContext context)
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
                return Ok(TalentCalculatorDTO.ToDTO(warcraftClass));
            }

            return BadRequest();
        }
    }
}
