using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonTests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(5,5);

            axe.Attack(dummy);

            Assert.AreEqual(5, dummy.Health, "Dummy does not lose health points when attacked.");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(5,5);
            Axe axe = new Axe(10,10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy), "Dead dummy does not throw exception when attacked.");
        }

        [Test]
        public void DeadDummyGivesExp()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.AreEqual(10, dummy.GiveExperience(), "Dead dummy does not give experience!");
        }

        [Test]
        public void AliveDummyThrowsExceptionWhenGivingExp()
        {
            Dummy dummy = new Dummy(20, 20);

            Assert.Throws<InvalidOperationException>((() => dummy.GiveExperience()), "Living dummy does not throw exception when attempting to give experience.");
        }
    }
}
