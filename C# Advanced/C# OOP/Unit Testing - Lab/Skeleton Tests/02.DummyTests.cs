using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void LoseHealthAfterAttack()
        {
            // Arrange
            Dummy dummy = new Dummy(100, 100);

            // Act
            dummy.TakeAttack(10);

            // Assert
            Assert.That(dummy.Health is 90);
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            // Arrange
            Dummy dummy = new Dummy(0, 10);

            // Act
            var exception = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));

            // Assert
            Assert.That(exception.Message is "Dummy is dead.");
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 10);

            // Act
            dummy.TakeAttack(10);

            //Assert
            Assert.That(dummy.GiveExperience() is 10);
        }

        [Test]
        public void AliveDummyCannotGiveExperience()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            var exception = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

            //Assert
            Assert.That(exception.Message is "Target is not dead.");
        }
    }
}