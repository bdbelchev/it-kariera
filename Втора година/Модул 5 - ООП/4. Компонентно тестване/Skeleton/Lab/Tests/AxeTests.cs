using System;
using NUnit.Framework;

namespace Tests
{
    public class AxeTests
    {
        private Dummy dummy;
        private Axe axe;

        [SetUp]
        public void InitializeObjects()
        {
            dummy = new Dummy(10, 10);
            axe = new Axe(10, 10);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints, "Axe doesn't lose durability after attacking");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            axe = new Axe(2, 2);

            axe.Attack(dummy);
            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>((() => axe.Attack(dummy)), "Broken axes cannot attack");
        }
    }
}