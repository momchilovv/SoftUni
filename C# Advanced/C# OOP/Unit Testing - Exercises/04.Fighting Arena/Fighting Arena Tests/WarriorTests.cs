namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void ConstructorShouldInitializeName()
        {
            // Arrange
            string expectedName = "Pesho";
            Warrior warrior = new Warrior(expectedName, 100, 100);

            // Act & Assert
            Assert.AreEqual(expectedName, warrior.Name);
        }

        [Test]
        public void ConstructorShouldInitializeDamage()
        {
            // Arrange
            int expectedDamage = 50;
            Warrior warrior = new Warrior("Pesho", expectedDamage, 100);

            // Act & Assert
            Assert.AreEqual(expectedDamage, warrior.Damage);
        }

        [Test]
        public void ConstructorShouldInitializeHp()
        {
            // Arrange
            int expectedHp = 50;
            Warrior warrior = new Warrior("Pesho", 100, expectedHp);

            // Act & Assert
            Assert.AreEqual(expectedHp, warrior.HP);
        }

        [TestCase("Pesho")]
        [TestCase("P")]
        [TestCase("Neprotivokonstituciovatelstvuvaite")]
        public void ConstructorShouldSetValidName(string name)
        {
            // Arrange & Act
            Warrior warrior = new Warrior(name, 100, 100);
            
            string expectedName = name;
            string actualName = warrior.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void NullEmptyOrWhiteSpaceNameShouldThrowException(string name)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, 100, 100);
            }, "Name should not be empty or whitespace!");
        }

        [TestCase(100)]
        [TestCase(50)]
        [TestCase(1)]
        public void ConstructorShouldSetValidDamage(int damage)
        {
            // Arrange & Act
            Warrior warrior = new Warrior("Pesho", damage, 100);

            int expectedDamage = damage;
            int actualDamage = warrior.Damage;

            // Assert
            Assert.AreEqual(expectedDamage, actualDamage);
        }

        [TestCase(-50)]
        [TestCase(-1)]
        [TestCase(0)]
        public void NegativeDamageShouldThrowException(int damage)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Pesho", damage, 100);
            }, "Damage value should be positive!");
        }

        [TestCase(50)]
        [TestCase(10)]
        [TestCase(0)]
        public void ConstructorShouldSetValidHp(int healtPoints)
        {
            // Arrange & Act
            Warrior warrior = new Warrior("Pesho", 100, healtPoints);

            int expectedHealthPoints = healtPoints;
            int actualHealthPoints = warrior.HP;

            // Assert
            Assert.AreEqual(expectedHealthPoints, actualHealthPoints);
        }

        [TestCase(-50)]
        [TestCase(-10)]
        [TestCase(-1)]
        public void NegativeHpShouldThrowException(int healthPoints)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior("Pesho", 100, healthPoints);
            }, "HP should not be negative!");
        }

        [TestCase(20)]
        [TestCase(30)]
        public void AttackingWarriorHavingLowHpShouldThrowException(int healthPoints)
        {
            // Arrange
            Warrior attacking = new Warrior("Pesho", 100, healthPoints);
            Warrior attacked = new Warrior("Gosho", 100, 100);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacking.Attack(attacked);
            }, "Your HP is too low in order to attack other warriors!");
        }

        [TestCase(20)]
        [TestCase(30)]
        public void EnemyWariorWithLowHpShouldThrowException(int healthPoints)
        {
            // Arrange
            int minAttackHp = 30;

            Warrior attacking = new Warrior("Pesho", 100, 100);
            Warrior attacked = new Warrior("Gosho", 100, healthPoints);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacking.Attack(attacked);
            }, $"Enemy HP must be greater than {minAttackHp} in order to attack him!");
        }

        [TestCase(50)]
        [TestCase(60)]
        public void AttackingStrongerEnemyShouldThrowException(int healthPoints)
        {
            // Arrange
            Warrior attacking = new Warrior("Pesho", 100, healthPoints);
            Warrior attacked = new Warrior("Gosho", 100, 100);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacking.Attack(attacking);
            }, "You are trying to attack too strong enemy");
        }

        [TestCase(30)]
        [TestCase(40)]
        public void AttackingWarriorTakesDamageFromTheEnemyWarrior(int damage)
        {
            // Arrange
            Warrior attacking = new Warrior("Pesho", 20, 100);
            Warrior attacked = new Warrior("Gosho", damage, 100);
            int expectedHealthPoints = 100 - damage;

            // Act
            attacking.Attack(attacked);
            int actualHealthPoints = attacking.HP;

            // Assert
            Assert.AreEqual(expectedHealthPoints, actualHealthPoints);
        }

        [TestCase(40)]
        [TestCase(50)]
        public void AttackingEnemyWarriorWithEnoughDamageToKillHim(int damage)
        {
            // Arrange
            Warrior attacking = new Warrior("Pesho", damage, 100);
            Warrior attacked = new Warrior("Gosho", 10, 40);
            int expectedEnemyHp = 0;

            // Act
            attacking.Attack(attacked);

            // Assert
            Assert.AreEqual(expectedEnemyHp, attacked.HP);
        }

        [TestCase(40)]
        [TestCase(50)]
        public void AttackingEnemyWarriorWithoutKillingHim(int damage)
        {
            // Arrange
            Warrior attacking = new Warrior("Pesho", damage, 100);
            Warrior attacked = new Warrior("Gosho", 10, 100);
            int expectedEnemyHp = 100 - damage;

            // Act
            attacking.Attack(attacked);

            // Assert
            Assert.AreEqual(expectedEnemyHp, attacked.HP);
        }
    }
}