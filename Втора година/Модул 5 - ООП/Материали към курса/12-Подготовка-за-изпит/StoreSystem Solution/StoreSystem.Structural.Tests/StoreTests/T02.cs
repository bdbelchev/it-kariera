using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StoreSystem.Structural.Tests.StoreTests
{
    public class T02
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Store"),
        };

        private Dictionary<string, Type> propertiesTypes = new Dictionary<string, Type>()
        {
            { "Name", typeof(string) },
            { "Type", typeof(string) },
            { "Revenue", typeof(double) },
        };

        [Test]
        public void TestStorePropertiesExist()
        {
            foreach (var className in classes)
            {
                AssertFields(className);
            }
        }

        private void AssertFields(Type className)
        {
            var properties = className
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var propertyInfo in properties)
            {
                Assert.IsTrue(this.propertiesTypes.ContainsKey(propertyInfo.Name), $"{propertyInfo.Name} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }
    }
}
