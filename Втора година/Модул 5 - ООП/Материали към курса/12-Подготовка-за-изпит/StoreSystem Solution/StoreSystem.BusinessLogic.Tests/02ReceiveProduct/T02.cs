using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._02ReceiveProduct
{
    public class T02
    {
        private Type sut = typeof(StoreController);
        private object[] receiveProductArgs = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Invalid Store: Valid Store Name. Cannot find it in system!";

        [Test]
        public void TestCreateStore()
        {
            var receiveProduct = sut.GetMethod("ReceiveProduct");

            string checkMessage = (string)receiveProduct.Invoke(arenaController, receiveProductArgs);

            Assert.AreEqual(expectedOutput, checkMessage);
        }

    }
}