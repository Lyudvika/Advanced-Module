using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(10, 5);

            dummy.TakeAttack(4);

            Assert.AreEqual(6, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsAnExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 5);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(4));

            Assert.AreEqual("Dummy is dead.", exception.Message);
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 5);

            Assert.AreEqual(5, dummy.GiveExperience());
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            Dummy dummy = new Dummy(10, 5);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

            Assert.AreEqual("Target is not dead.", exception.Message);
        }
    }
}