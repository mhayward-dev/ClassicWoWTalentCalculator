using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frameworks.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }
    }
}
