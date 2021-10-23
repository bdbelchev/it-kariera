using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StoreSystem.Structural.Tests.ProductTests.Product
{
    public class T01
    {
        private static readonly Assembly ProjectAssembly = typeof(global::StartUp).Assembly;

        // Class names
        private Type[] classes =
        {
            GetType("Product"),
        };


        [Test]
        public void TestProductFieldIsPrivate()
        {
            foreach (var className in classes)
            {
                AssertFields(className);
            }
        }

        private void AssertFields(Type className)
        {
            var fields = className
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate,
                    $"{fieldInfo.Name} in {className.Name} is NOT Private");
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
