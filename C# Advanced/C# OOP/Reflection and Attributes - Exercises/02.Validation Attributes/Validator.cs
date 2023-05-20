using System;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.IsDefined(typeof(MyRequiredAttribute), inherit: true))
                {
                    var value = property.GetValue(obj);

                    if (value == null)
                    {
                        return false;
                    }
                }
            }

            foreach (var property in properties)
            {
                if (property.IsDefined(typeof(MyRangeAttribute), inherit: true))
                {
                    var value = property.GetValue(obj);

                    var rangeAttribute = (MyRangeAttribute)Attribute.GetCustomAttribute(property, typeof(MyRangeAttribute));

                    int minValue = rangeAttribute.minValue;
                    int maxValue = rangeAttribute.maxValue;

                    if (value == null || (int)value < minValue || (int)value > maxValue)
                    {
                        return false;   
                    }
                }
            }

            return true;
        }
    }
}