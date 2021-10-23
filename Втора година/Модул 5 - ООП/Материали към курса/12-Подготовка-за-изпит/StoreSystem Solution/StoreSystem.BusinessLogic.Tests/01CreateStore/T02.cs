using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._01CreateStore
{
    public class T02
    {
        private Type sut = typeof(StoreController);
        private object[] createStoreArgs = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Store Valid Store Name is already registered!";

        [Test]
        public void TestCreateStore() 
        {
            var createStore = sut.GetMethod("CreateStore");

            createStore.Invoke(arenaController, createStoreArgs);
            string checkMessage = (string)createStore.Invoke(arenaController, createStoreArgs);

            Assert.AreEqual(expectedOutput, checkMessage);
        }

    }
}
