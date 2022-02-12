using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Skeleton;

namespace SkeletonTests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroGainsExpAfterTargetDies()
        {
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero("Name", fakeWeapon.Object);

            hero.Attack(fakeTarget.Object);

            Assert.AreEqual(20, hero.Experience, "Hero does not get Experience after target dies.");
        }
    }
}
