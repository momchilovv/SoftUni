using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string AnalyzeAccessModifiers(string className)
        {
            var sb = new StringBuilder();

            var type = Type.GetType(className);

            var fields = type!.GetFields().Where(f => !f.IsPrivate);

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            var publicMethods = type!.GetMethods(BindingFlags.Instance | BindingFlags.Public);

            foreach (var method in publicMethods)
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            var nonPublicMethods = type!.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in nonPublicMethods)
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            return sb.ToString().Trim();
        }

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