using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAProcess
{
    /// <summary>
    /// Get Attribute of Class
    /// Example : string name = typeof(MyClass).GetAttributeValue((MyClass obj) => obj.Name);
    /// </summary>
    public static class AttributeExtensions
    {
        public static TValue GetAttributeValue<TAttribute, TValue>(
        this Type type,
        Func<TAttribute, TValue> valueSelector)
        where TAttribute : Attribute
        {
            var att = type.GetCustomAttributes(
                typeof(TAttribute), true
            ).FirstOrDefault() as TAttribute;
            if (att != null)
            {
                return valueSelector(att);
            }
            return default(TValue);
        }
    }
}
