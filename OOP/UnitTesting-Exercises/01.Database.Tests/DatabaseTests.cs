namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.ComponentModel;

    [TestFixture]
    public class DatabaseTests
    {
        Database database = new Database();
        [SetUp]
        public void StartDatabase()
        {
            database = new Database(1, 2);
        }

        [Test]
        public void ConstructureShouldWorkCorrectly()
        {
            int expectedResult = 2;
            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void CreateDatabaseShouldThrowAnExceptionWhenCountIsMoreThan16(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() => database =  new Database(data));
        }

        [Test]
        public void AddMetodShouldAddNumbersCorrectly()
        {
            for (int i = 0; i < 10; i++)
            {
                database.Add(i);
            }

            int expectedResult = 12;
            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddMetodShouldThrowExceptionIfThereAreMoreThan16Numbers()
        {
            for (int i = 0; i < 14; i++)
            {
                database.Add(i);
            }

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(123));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", exception.Message);
        }

        [Test]
        public void RemoveMethodShouldWorkCorrectly()
        {
            database.Remove();

            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowAnExceptionIfProceedWhileDatabaseIsEmpty()
        {
            database.Remove();
            database.Remove();

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Remove());

            Assert.AreEqual("The collection is empty!", exception.Message);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5})]
        public void FetchMethodShouldWorkCorrectly(int[] data)
        {
            database = new Database(data);

            int[] actualResult = database.Fetch();

            Assert.AreEqual(data, actualResult);
        }
    }
}
