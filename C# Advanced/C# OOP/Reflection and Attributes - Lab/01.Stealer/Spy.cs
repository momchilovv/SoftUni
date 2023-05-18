using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {className}");

            var type = Type.GetType(className);

            var fields = Type.GetType(className)!
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic 
                | BindingFlags.Static | BindingFlags.Public);

            var instance = Activator.CreateInstance(type!, new object[] { });

            foreach (var field in fields.Where(f => fieldNames.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }

            return sb.ToString().Trim();
        }
    }
}