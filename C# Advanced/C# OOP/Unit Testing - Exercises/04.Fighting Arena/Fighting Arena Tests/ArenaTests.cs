namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
        }

        [Test]
        public void ConstructorShouldInitializeArena()
        {
            // Arrange & Act
            Arena constructorArena = new Arena();

            // Assert
            Assert.IsNotNull(constructorArena.Warriors);
        }

        [Test]
        public void ArenaReturnsTheCountOfWarriorsInIt()
        {
            // Arrange & Act
            for (int i = 0; i < 5; i++)
            {
                Warrior warrior = new Warrior($"Pesho{i}", 10, 10);

                arena.Enroll(warrior);
            }

            // Assert
            Assert.AreEqual(5, arena.Warriors.Count);
        }

        [Test]
        public void EnrollNonExistingWarriorShouldSucceed()
        {
            // Arrange
            Warrior warrior = new Warrior("Pesho", 100, 100);

            // Act
            arena.Enroll(warrior);

            // Assert
            Assert.IsTrue(arena.Warriors.Contains(warrior));
        }

        [Test]
        public void EnrollExistingWarriorShouldThrowException()
        {
            // Arrange
            Warrior warrior = new Warrior("Pesho", 100, 100);

            // Act
            arena.Enroll(warrior);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warrior);
            }, "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void EnrollWarriorWithTheSameNameShouldThrowException()
        {
            // Arrange
            Warrior warrior1 = new Warrior("Pesho", 50, 100);
            Warrior warrior2 = new Warrior("Pesho", 20, 99);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warrior1);
                arena.Enroll(warrior2);
            }, "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void BothWarriorsExistInArenaWhenFighting()
        {
            // Arrange
            Warrior warrior1 = new Warrior("Pesho", 20, 100);
            Warrior warrior2 = new Warrior("Gosho", 30, 100);

            int expectedWarrior1Hp = warrior1.HP - warrior2.Damage;
            int expectedWarrior2Hp = warrior2.HP - warrior1.Damage;

            arena.Enroll(warrior1);
            arena.Enroll(warrior2);

            // Act
            arena.Fight(warrior1.Name, warrior2.Name);

            // Assert
            Assert.AreEqual(expectedWarrior1Hp, warrior1.HP);
            Assert.AreEqual(expectedWarrior2Hp, warrior2.HP);
        }

        [TestCase("Gosho")]
        [TestCase("Marin")]
        public void AttackingWarriorIsNotEnrolledWhenFightingThrowsException(string name)
        {
            // Arrange
            Warrior warrior = new Warrior("Pesho", 100, 100);
            arena.Enroll(warrior);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(name, warrior.Name);
            }, $"There is no fighter with name {name} enrolled for the fights!");
        }

        [TestCase("Goshko")]
        [TestCase("Marincho")]
        public void DefendingWarriorIsNotEnrolledWhenFightingThrowsException(string name)
        {
            // Arrange
            Warrior warrior = new Warrior("Pesho", 100, 100);
            arena.Enroll(warrior);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(warrior.Name, name);
            }, $"There is no fighter with name {name} enrolled for the fights!");
        }
    }
}