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

        public WarcraftClass GetById(int id, bool eagerLoad = false)
        {
            return eagerLoad ? Context.WarcraftClasses.Include(wc => wc.WarcraftClassSpecifications)
                                                        .ThenInclude(wcs => wcs.SpecificationTalents)
                                                            .ThenInclude(wcs => wcs.TalentRanks)
                                                      .Include(wc => wc.WarcraftClassSpecifications)
                                                        .ThenInclude(wcs => wcs.SpecificationTalents)
                                                            .ThenInclude(wcs => wcs.TalentIcon)
                                                      .FirstOrDefault(wc => wc.Id == id)
                             : base.GetById(id);
        }
    }
}
