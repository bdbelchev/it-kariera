using System;
using NUnit.Framework;

namespace Tests
{
    class DummyTests
    {
        private Dummy dummy;
        private Axe axe;

        [SetUp]
        public void InitializeObjects()
        {
            dummy = new Dummy(1, 5);
            axe = new Axe(1, 5);
        }

        [Test]
        public void DummyLosesHealthWhenAttacked()
        {
            dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, dummy.Health, "Dummy does not lose health when attacked");
        }

        [Test]
        public void DeadDummiesThrowExceptionsWhenAttacked()
        {
            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>((() => axe.Attack(dummy)), "Dead dummy does not throw an exception when attacked");
        }

        [Test]
        public void DeadDummiesCanGiveExp()
        {
            axe.Attack(dummy);

            Assert.AreEqual(5, dummy.GiveExperience(), "Dead dummy does not give required amount of experience");
        }

        [Test]
        public void LivingDummiesCannotGiveExp()
        {
            Assert.Throws<InvalidOperationException>((() => dummy.GiveExperience()), "Living dummy cannot give experience");
        }
    }
}
