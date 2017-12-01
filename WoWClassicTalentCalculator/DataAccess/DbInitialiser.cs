using System;
using System.Collections.Generic;
using System.Linq;

namespace WoWClassicTalentCalculator.DataAccess
{
    public static class DbInitialiser
    {
        public static void Initialise(TalentCalculatorContext context)
        {
            context.Database.EnsureCreated();

            if (!context.WarcraftClasses.Any())
            {
                DbSeeder.Seed(context);
            }
        }
    }
}
