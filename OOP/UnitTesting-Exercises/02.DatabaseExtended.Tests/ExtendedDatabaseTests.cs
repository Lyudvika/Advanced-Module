namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            Person[] persons =
            {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko")
        };

            database = new Database(persons);
        }

        [Test]
        public void PersonClassConstructorShouldWorkCorrectly()
        {
            Person person = new Person(200, "Human");

            Assert.AreEqual(200, person.Id);
            Assert.AreEqual("Human", person.UserName);
        }

        [Test]
        public void DatabaseClassConstructorShouldWorkCorrectly()
        {
            Assert.AreEqual(11, database.Count);
        }

        [Test]
        public void AddRangeMethodShouldThrowAnExceptionWhenAddingMoreThan16People()
        {
            Person[] persons =
            {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko"),
            new Person(12, "Gigo"),
            new Person(13, "Viki"),
            new Person(14, "Ivo"),
            new Person(15, "Blago"),
            new Person(16, "Pesnka"),
            new Person(17, "Kiril")
            };

            ArgumentException exception = Assert.Throws<ArgumentException>(() => database = new Database(persons));

            Assert.AreEqual("Provided data length should be in range [0..16]!", exception.Message);
        }

        [Test]
        public void AddMethodShouldWorkCorrectly()
        {
            Person person = new Person(12, "Gigo");
            database.Add(person);

            Assert.AreEqual(12, database.Count);
        }

        [Test]
        public void AddMethodShouldAnExceptionWhenHaving16People()
        {
            Person person = new Person(12, "Gigo");
            Person person2 = new Person(13, "Viki");
            Person person3 = new Person(14, "Ivo");
            Person person4 = new Person(15, "Blago");
            Person person5 = new Person(16, "Pesnka");
            Person person6 = new Person(17, "Kiril");


            database.Add(person);
            database.Add(person2);
            database.Add(person3);
            database.Add(person4);
            database.Add(person5);


            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(person6));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", exception.Message);
        }

        [Test]
        public void AddMethodShouldThrowAnExceptionIfThereIsAlreadyAPersonWithTheSameUserName()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(new Person(12, "Toshko")));

            Assert.AreEqual("There is already user with this username!", exception.Message);
        }

        [Test]
        public void AddMethodShouldThrowAnExceptionIfThereIsAlreadyAPersonWithTheSameId()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(new Person(11, "Gigo")));

            Assert.AreEqual("There is already user with this Id!", exception.Message);
        }

        [Test]
        public void RemoveMethodShouldWorkCorrectly()
        {
            database.Remove();

            int expectedResult = 10;
            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveMethodShouldThrowAnExceptionWhenEmpty()
        {
            database = new Database();

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FindByUsernameShouldWorkCorrectly()
        {
            Person actualResult = database.FindByUsername("Toshko");
            int expectedId = 11;
            string expectedUsername = "Toshko";

            Assert.AreEqual(expectedId, actualResult.Id);
            Assert.AreEqual(expectedUsername, actualResult.UserName);
        }

        [TestCase("")]
        [TestCase(null)]
        public void FindByUsernameShouldThrowAnExceptionWhenNullOrEmpty(string username)
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username));

            Assert.AreEqual("Username parameter is null!", exception.ParamName);
        }

        [Test]
        public void FindByUsernameShouldBeCaseSensitive()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.FindByUsername("ToshkO"));

            Assert.AreEqual("No user is present by this username!", exception.Message);
        }

        [Test]
        public void FindByUsernameShouldThrowAnExceptionWhneUsernameDoesntExist()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Pipi"));

            Assert.AreEqual("No user is present by this username!", exception.Message);
        }

        [Test]
        public void FindByIdShouldWorkCorrectly()
        {
            Person actualResult = database.FindById(11);
            int expectedId = 11;
            string expectedUsername = "Toshko";

            Assert.AreEqual(expectedId, actualResult.Id);
            Assert.AreEqual(expectedUsername, actualResult.UserName);
        }

        [Test]
        public void FindByIdShouldThrowAnExceptionWhenIdIsLessThanZero()
        {
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));

            Assert.AreEqual("Id should be a positive number!", exception.ParamName);
        }

        [Test]
        public void FindByIdShouldThrowAnExceptionWhenIdIsntFound()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.FindById(12));

            Assert.AreEqual("No user is present by this ID!", exception.Message);
        }
    }
}