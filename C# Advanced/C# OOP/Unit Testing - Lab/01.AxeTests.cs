using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void LooseDurabilityAfterAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(100, 100);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe durability doesn't change after attack.");
        }

        [Test]
        public void CannotAttackWithBrokenWeapon()
        {
            // Arrange
            Axe axe = new Axe(0, 0);
            Dummy dummy = new Dummy(100, 100);

            // Act
            var exception = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

            // Assert
            Assert.That(exception.Message is "Axe is broken.");
        }
    }
}