using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace StoreSystem.Structural.Tests.StoreTests
{
    public class T08
    {
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        private Type sut = GetType("Store");

        [Test]
        public void TestReceiveProductMethodExists()
        {
            var sellProduct = sut.GetMethod("SellProduct");

            Assert.IsNotNull(sellProduct);
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
