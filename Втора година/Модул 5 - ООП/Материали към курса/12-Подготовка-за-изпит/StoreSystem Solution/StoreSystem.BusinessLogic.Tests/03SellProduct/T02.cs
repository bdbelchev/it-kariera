using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._03SellProduct
{
    public class T02
    {
        private Type sut = typeof(StoreController);
        private object[] sellProductArgs = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Invalid Store: Valid Store Name. Cannot find it in system!";

        [Test]
        public void TestCreateStore()
        {
            var sellProduct = sut.GetMethod("SellProduct");

            string checkMessage = (string)sellProduct.Invoke(arenaController, sellProductArgs);

            Assert.AreEqual(expectedOutput, checkMessage);
        }

    }
}
