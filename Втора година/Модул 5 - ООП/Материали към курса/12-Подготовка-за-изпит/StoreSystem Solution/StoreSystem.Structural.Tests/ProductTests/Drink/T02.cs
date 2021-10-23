using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StoreSystem.Structural.Tests.ProductTests.Drink
{
    public class T02
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Drink"),
        };

        private Type baseClass = GetType("Product");

        [Test]
        public void TestDrinkBaseClass()
        {
            foreach (var className in classes)
            {
                AssertBaseClass(className);
            }
        }

        private void AssertBaseClass(Type className)
        {
            Assert.True(className.BaseType == baseClass);
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
