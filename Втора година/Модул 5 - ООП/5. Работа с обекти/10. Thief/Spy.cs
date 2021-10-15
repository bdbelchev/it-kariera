using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _10._Thief
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            Console.WriteLine($"Class under investigation: {className}");

            StringBuilder sb = new StringBuilder();

            Type type = Type.GetType($"_10._Thief.{className}");
            FieldInfo[] fieldInfo = new FieldInfo[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                fieldInfo[i] = type.GetField(fields[i], BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            }

            object testInstance = Activator.CreateInstance(type);

            foreach (FieldInfo info in fieldInfo)
            {
                sb.AppendLine($"{info.Name} = {info.GetValue(testInstance)}");
            }

            return sb.ToString();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type type = Type.GetType($"_10._Thief.{className}");

            FieldInfo[] publicFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            MethodInfo[] privateMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            MethodInfo[] publicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            foreach (FieldInfo field in publicFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in privateMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} has to be public!");
            }

            foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} has to be private!");
            }

            return sb.ToString();
        }

        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type type = Type.GetType($"_10._Thief.{className}");

            sb.AppendLine($"All Private Methods of Class: {type.Name}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");

            MethodInfo[] privateMethods =
                type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            foreach (MethodInfo method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString();
        }

        public string CollectGettersAndSetters(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type type = Type.GetType($"_10._Thief.{className}");

            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (MethodInfo getter in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
            }

            foreach (MethodInfo setter in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
            }

            return sb.ToString();
        }
    }
}
