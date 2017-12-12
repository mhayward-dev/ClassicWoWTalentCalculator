using System;
using System.ComponentModel;

namespace Frameworks.Extensions
{
    public static class EnumExtensions
    {
        public static string FormattedName(this Enum value)
        {
            var name = Enum.GetName(value.GetType(), value);
            var attr = (DescriptionAttribute)GetAttribute(typeof(DescriptionAttribute), value);

            return attr.IsNotNull() ? attr.Description : name;
        }

        public static Attribute GetAttribute(Type t, Enum e)
        {
            var name = Enum.GetName(e.GetType(), e);
            var fieldInfo = e.GetType().GetField(name);

            return Attribute.GetCustomAttribute(fieldInfo, t);
        }
    }
}
