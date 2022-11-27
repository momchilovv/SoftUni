namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void AddingNameThatExistsInDbThrowsException()
        {
            // Arrange
            Database database = new Database(new Person(1234, "Pesho"));
            Person person = new Person(5678, "Pesho");

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(person);

            }, "There is already user with this username!");
        }

        [Test]
        public void AddingIdThatExistsInDbThrowsException()
        {
            // Arrange
            Database database = new Database(new Person(1234, "Pesho"));
            Person person = new Person(1234, "PeshoVtori");

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(person);

            }, "There is already user with this Id!");
        }

        [Test]
        public void AddingPersonUpdatesTheCount()
        {
            // Arrange
            Database database = new Database();

            Person person = new Person(1234, "Pesho");
            Person person2 = new Person(5678, "Gosho");

            // Act
            database.Add(person);
            database.Add(person2);

            // Assert
            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void RemovingPersonUpdatesTheCount()
        {
            // Arrange
            Database database = new Database();

            Person person = new Person(1234, "Pesho");
            Person person2 = new Person(5678, "Gosho");

            database.Add(person);
            database.Add(person2);

            // Act
            database.Remove();

            // Assert
            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void RemovingFromEmptyDbThrowsException()
        {
            // Arrange
            Database database = new Database();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [Test]
        public void AddingMorePeopleThanMaxCapacityThrowsException()
        {
            // Arrange
            Database database = new Database();

            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, $"Name + {i}"));
            }

            Person person = new Person(1337, "Pesho");

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(person);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(null)]
        [TestCase("")]
        public void FindByUsernameIsNullOrEmptyThrowsException(string name)
        {
            // Arrange
            Database database = new Database();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername(name);
            }, "Username parameter is null!");
        }

        [Test]
        public void FindByUsernameWhichDoesntExistThrowsException()
        {
            // Arrange
            Database database = new Database();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername("username");
            }, "No user is present by this username!");
        }

        [Test]
        public void FindByUsernameIsSuccessful()
        {
            // Arrange
            Person person = new Person(1234, "Pesho");
            Database database = new Database(person);

            // Act
            var expectedPerson = database.FindByUsername("Pesho");

            // Assert
            Assert.AreEqual(expectedPerson, person);
        }

        [TestCase(-1)]
        [TestCase(-40)]
        public void FindByIdWithNegativeNumbersThrowsException(long id)
        {
            // Arrange
            Database database = new Database();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                database.FindById(id);
            }, "Id should be a positive number!");
        }

        [Test]
        public void FindByIdWhichDoesntExistThrowsException()
        {
            // Arrange
            Database database = new Database();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindById(1337);
            }, "No user is present by this ID!");
        }

        [Test]
        public void FindByIdIsSuccessful()
        {
            // Arrange
            Person person = new Person(1337, "Pesho");
            Database database = new Database(person);

            // Act
            var expectedPerson = database.FindById(1337);

            // Assert
            Assert.AreEqual(expectedPerson, person);
        }

        [Test]
        public void ConstructorAddsMorePeopleThanMaxCapacityThrowsException()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Database database = new Database(new Person[17]);
            }, "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void ConstructorAddsLessPeopleThanMaxCapacity()
        {
            // Arrange
            Database database = new Database();

            for (int i = 0; i < 5; i++)
            {
                database.Add(new Person(i, $"Name + {i}"));
            }

            Person person = new Person(1337, "Pesho");

            // Act
            database.Add(person);
            int expectedCount = 6;

            // Assert
            Assert.AreEqual(expectedCount, database.Count);
        }
    }
}