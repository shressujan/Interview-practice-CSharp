using System;
using System.ComponentModel;
using System.Reflection;

namespace Enums
{
    public enum Season
    {
        [Description("Cold and rainy")] Fall,
        [Description("Fresh and Calm")] Spring,
        [Description("Hot and Wet")] Summer,
        [Description("Freezing and Dry")] Winter
    }
    
    static class EnumHelper
    {
        public static string GetDescription(this Enum e)
        {
            Type eType = e.GetType();
            string eName = Enum.GetName(eType, e);
            if (eName != null)
            {
                FieldInfo fieldInfo = eType.GetField(eName);
                if (fieldInfo != null)
                {
                    DescriptionAttribute descriptionAttribute =
                        Attribute.GetCustomAttribute(fieldInfo,
                            typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (descriptionAttribute != null)
                    {
                        return descriptionAttribute.Description;
                    }
                }
            }
            return null;
        }
    }

}