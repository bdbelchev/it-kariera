using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._03SellProduct
{
    public class T01
    {
        private Type sut = typeof(StoreController);
        private object[] createStoreArgs = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private object[] sellProductArgs = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Product FoodName was successfully bought from Valid Store Name!";

        [Test]
        public void TestCreateStore()
        {
            var sellProduct = sut.GetMethod("SellProduct");
            var receiveProduct = sut.GetMethod("ReceiveProduct");
            var createStore = sut.GetMethod("CreateStore");

            createStore.Invoke(arenaController, createStoreArgs);
            receiveProduct.Invoke(arenaController, receiveProductArgs);
            string checkMessage = (string)sellProduct.Invoke(arenaController, sellProductArgs);

            Assert.AreEqual(expectedOutput, checkMessage);
        }

    }
}
