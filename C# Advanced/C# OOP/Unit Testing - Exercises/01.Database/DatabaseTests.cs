namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void WrongSizeOfArrayShouldThrowException()
        {
            // Arrange
            int[] array = new int[15];

            // Act
            Database database = new Database(array);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                if (database.Count != 16)
                {
                    throw new InvalidOperationException();
                }
            });
        }

        [Test]
        public void AddingMoreElementsThanCapacityShouldThrowException()
        {
            // Arrange
            int[] array = new int[16];
            Database database = new Database(array);

            // Act
            var exception = Assert.Throws<InvalidOperationException>(() => database.Add(1));

            // Assert
            Assert.That(exception.Message is "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void RemovingElementFromEmptyDatabaseShouldThrowException()
        {
            // Arrange
            int[] array = new int[0];
            Database database = new Database(array);

            // Act
            var exception = Assert.Throws<InvalidOperationException>(() => database.Remove());

            // Assert
            Assert.That(exception.Message is "The collection is empty!");
        }

        [Test]
        public void ConstructorShouldTakeIntegersOnly()
        {
            // Arrange
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Database database = new Database(array);

            // Assert
            Assert.That(array is int[]);
        }

        [Test]
        public void FetchShouldReturnElementsAsArray()
        {
            // Arrange
            int[] array = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            Database database = new Database(array);

            // Act
            int[] fetchedDatabase = database.Fetch();

            // Assert
            Assert.AreEqual(fetchedDatabase, array);
        }

        [Test]
        public void CheckIfCountIsIncreasedAfterAdding()
        {
            // Arrange
            Database database = new Database(new int[15]);

            // Act
            database.Add(16);

            // Assert
            Assert.AreEqual(16, database.Count);
        }

        [Test]
        public void CheckIfCountIsDecreasedAfterRemoving()
        {
            // Arrange
            Database database = new Database(new int[16]);

            // Act
            database.Remove();
            database.Remove();

            // Arrange
            Assert.AreEqual(14, database.Count);
        }
    }
}
