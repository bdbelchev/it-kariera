using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.BusinessLogic.Tests._01CreateStore
{
    public class T01
    {
        private Type sut = typeof(StoreController);
        private object[] createStoreArgs = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private StoreController arenaController = new StoreController();
        private string expectedOutput =
            $"Store Valid Store Name was successfully registerd in the system!";

        [Test]
        public void TestCreateStore() 
        {
            var createHero = sut.GetMethod("CreateStore");

            string checkMessage = (string)createHero.Invoke(arenaController, createStoreArgs);

            Assert.AreEqual(expectedOutput, checkMessage);
        }

    }
}
