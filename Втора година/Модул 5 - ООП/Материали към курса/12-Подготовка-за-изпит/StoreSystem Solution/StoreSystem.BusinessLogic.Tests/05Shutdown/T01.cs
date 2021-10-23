using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._05Shutdown
{
    public class T01
    {
        private Type sut = typeof(StoreController);
        private object[] createStoreArgs = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private object[] sellProductArgs = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private object[] storeInfoArgs = { new List<string>() { "Valid Store Name" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Stores: 1" + Environment.NewLine +
            $"****Store: Valid Store Name <Valid Type Store>" + Environment.NewLine +
            $"****Available products: <1>" + Environment.NewLine +
            $"****** FoodName (10)" + Environment.NewLine +
            $"****Revenue: <170.50BGN>" + Environment.NewLine +
            $"System Store Revenues: 170.50BGN";

        [Test]
        public void TestCreateStore()
        {
            var sellProduct = sut.GetMethod("SellProduct");
            var receiveProduct = sut.GetMethod("ReceiveProduct");
            var createStore = sut.GetMethod("CreateStore");
            var shutdown = sut.GetMethod("Shutdown");

            createStore.Invoke(arenaController, createStoreArgs);
            receiveProduct.Invoke(arenaController, receiveProductArgs);
            sellProduct.Invoke(arenaController, sellProductArgs);
            string checkMessage = (string)shutdown.Invoke(arenaController, new object[] { });

            Assert.AreEqual(expectedOutput, checkMessage);
        }
    }
}