using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StoreSystem.Structural.Tests.ProductTests.Product
{
    public class T05
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Product"),
        };

        private string propertyName = "PercentageMarkup";

        [Test]
        public void TestDeliverPriceSetMethodIsFamily()
        {
            foreach (var className in classes)
            {
                AssertPropertySetMethodIsFamily(className);
            }
        }

        private void AssertPropertySetMethodIsFamily(Type className)
        {
            var property = className
                .GetProperty(propertyName);

            Assert.IsTrue(property.SetMethod.IsFamily);
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
