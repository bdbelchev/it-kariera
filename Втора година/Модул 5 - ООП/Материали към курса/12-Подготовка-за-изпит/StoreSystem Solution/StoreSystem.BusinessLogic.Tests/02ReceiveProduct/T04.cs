﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._02ReceiveProduct
{
    public class T04
    {
        private Type sut = typeof(StoreController);
        private object[] createStoreArgs = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Product FoodName was already delivered to Valid Store Name!";

        [Test]
        public void TestCreateStore()
        {
            var receiveProduct = sut.GetMethod("ReceiveProduct");
            var createStore = sut.GetMethod("CreateStore");

            createStore.Invoke(arenaController, createStoreArgs);
            receiveProduct.Invoke(arenaController, receiveProductArgs);
            string checkMessage = (string)receiveProduct.Invoke(arenaController, receiveProductArgs);

            Assert.AreEqual(expectedOutput, checkMessage);
        }

    }
}