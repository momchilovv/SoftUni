using System;

namespace ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property)]

    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attribute = GetCustomAttribute(property, typeof(MyRequiredAttribute));

                if (attribute != null)
                {
                    return true;
                }
            }

            return false;   
        }
    }
}