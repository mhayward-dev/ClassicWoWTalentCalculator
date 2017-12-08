using Microsoft.EntityFrameworkCore;
using System.Linq;
using VanillaReborn.Models;

namespace VanillaReborn.DataAccess.Repositories
{
    public class WarcraftClassRepository : BaseRepository<WarcraftClass, WarcraftClassRepository>
    {
        public WarcraftClassRepository(VanillaRebornContext context) : base(context)
        {
            CurrentRepository = this;
        }

        public override WarcraftClassRepository EagerLoad()
        {
            Query = Query.Include(wc => wc.WarcraftClassSpecifications)
                            .ThenInclude(wcs => wcs.Talents)
                                .ThenInclude(t => t.TalentRanks)
                         .Include(wc => wc.WarcraftClassSpecifications)
                            .ThenInclude(wcs => wcs.Talents)
                                .ThenInclude(t => t.TalentIcon)
                         .Include(wc => wc.WarcraftClassSpecifications)
                            .ThenInclude(wcs => wcs.Talents)
                                .ThenInclude(t => t.TalentRequirement)
                                    .ThenInclude(tr => tr.RequiredTalent)
                                       .ThenInclude(rt => rt.TalentRanks);

            return this;
        }

        public WarcraftClassRepository ForClassName(string className)
        {
            Query = Query.Where(wc => wc.ClassName.ToLower() == className.ToLower());

            return this;
        }
    }
}
