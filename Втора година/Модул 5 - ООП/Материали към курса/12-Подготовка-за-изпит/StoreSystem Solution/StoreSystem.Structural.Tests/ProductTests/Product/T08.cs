using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace StoreSystem.Structural.Tests.ProductTests.Product
{
    public class T08
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Product"),
        };

        [Test]
        public void TestClassIsAbstract()
        {
            foreach (var className in classes)
            {
                AssertClassIsAbstract(className);
            }
        }

        private void AssertClassIsAbstract(Type className)
        {
            Assert.True(className.IsAbstract);
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
