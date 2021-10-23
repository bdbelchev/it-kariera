using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace StoreSystem.Structural.Tests.StoreTests
{
    public class T05
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Store"),
        };

        private string propertyName = "Type";

        [Test]
        public void TestNameSetMethodIsPrivate()
        {
            foreach (var className in classes)
            {
                AssertPropertySetMethodIsPrivate(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate(Type className)
        {
            var property = className
                .GetProperty(propertyName);

            Assert.IsTrue(property.SetMethod.IsPrivate,
                $"Property {propertyName} set method is not private");
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
