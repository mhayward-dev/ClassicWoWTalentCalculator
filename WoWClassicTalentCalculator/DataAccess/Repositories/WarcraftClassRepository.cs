using Microsoft.EntityFrameworkCore;
using System.Linq;
using WoWClassicTalentCalculator.Models;

namespace WoWClassicTalentCalculator.DataAccess.Repositories
{
    public class WarcraftClassRepository : BaseRepository<WarcraftClass, WarcraftClassRepository>
    {
        public WarcraftClassRepository(TalentCalculatorContext context) : base(context)
        {
            CurrentRepository = this;
        }

        public override WarcraftClassRepository EagerLoad()
        {
            Query = Query.Include(wc => wc.WarcraftClassSpecifications)
                            .ThenInclude(wcs => wcs.SpecificationTalents)
                                .ThenInclude(wcs => wcs.TalentRanks)
                         .Include(wc => wc.WarcraftClassSpecifications)
                            .ThenInclude(wcs => wcs.SpecificationTalents)
                                .ThenInclude(wcs => wcs.TalentIcon);

            return this;
        }

        public WarcraftClassRepository ForClassName(string className)
        {
            Query = Query.Where(wc => wc.ClassName.ToLower() == className.ToLower());

            return this;
        }
    }
}
