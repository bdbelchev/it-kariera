using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StoreSystem.Structural.Tests.ProductTests.Product
{
    public class T06
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Product"),
        };

        private Type[] constructorParametersTypes =
        {
            typeof(string),
            typeof(int),
            typeof(double),
            typeof(double),
        };

        [Test]
        public void TestConstructorParametersAndAccessModifier()
        {
            foreach (var className in classes)
            {
                AssertConstructorIsFamily(className);
            }
        }

        private void AssertConstructorIsFamily(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                constructorParametersTypes, null);

            Assert.IsNotNull(constructor);
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
