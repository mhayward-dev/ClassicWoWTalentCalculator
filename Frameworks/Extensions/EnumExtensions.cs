using System;
using System.Collections.Generic;
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

        public static Dictionary<int, string> ToDictionary<T>() where T : struct
        {
            var enumDict = new Dictionary<int, string>();
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                enumDict.Add((int)e, e.ToString());
            }

            return enumDict;
        }
    }
}
