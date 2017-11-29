using System.Collections.Generic;
using System.Linq;

namespace Frameworks.Extensions
{
    public static class CollectionExtensions
    {
        public static bool HasItems<T>(this IEnumerable<T> en)
        {
            return en.IsNotNull() && en.Any();
        }
    }
}
