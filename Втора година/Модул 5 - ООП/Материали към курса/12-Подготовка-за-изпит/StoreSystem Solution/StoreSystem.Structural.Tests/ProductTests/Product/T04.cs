using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StoreSystem.Structural.Tests.ProductTests.Product
{
    public class T04
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Product"),
        };

        private string propertyName = "DeliverPrice";

        [Test]
        public void TestDeliverPriceSetMethodIsPrivate()
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

            Assert.IsTrue(property.SetMethod.IsPrivate);
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
