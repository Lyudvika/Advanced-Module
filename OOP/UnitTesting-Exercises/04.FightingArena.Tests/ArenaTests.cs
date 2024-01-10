namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Threading;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void When_CreatingANewArena_Data_ShouldBeSetCorrectly()
        {
            Assert.IsNotNull(arena);
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void When_AddingWarriorToArena_CountBeSetCorrectly()
        {
            Warrior warrior = new Warrior("Gosho", 40, 100);
            arena.Enroll(warrior);

            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        public void When_AddingWarriorToArena_Data_ShouldBeSetCorrectly()
        {
            Warrior warrior = new("Gosho", 40, 100);

            arena.Enroll(warrior);

            Assert.IsNotEmpty(arena.Warriors);
            Assert.AreEqual(warrior, arena.Warriors.Single());
        }

        [Test]
        public void When_AddingWarriorWithTheSameName_ShouldThrowAnException()
        {
            Warrior warrior = new("Gosho", 40, 100);
            Warrior warrior2 = new("Gosho", 50, 100);

            arena.Enroll(warrior);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior2));
            Assert.AreEqual("Warrior is already enrolled for the fights!", exception.Message);
        }

        [Test]
        public void When_WarriorFightAnEnemy_Data_ShouldBeSetCorrectly()
        {
            Warrior warrior = new("Gosho", 40, 100);
            Warrior enemy = new("Viki", 50, 100);

            arena.Enroll(warrior);
            arena.Enroll(enemy);

            int expectedWarriorHp = 50;
            int expectedEnemyHp = 60;

            arena.Fight(warrior.Name, enemy.Name);

            Assert.AreEqual(expectedWarriorHp, warrior.HP);
            Assert.AreEqual(expectedEnemyHp, enemy.HP);
        }

        [Test]
        public void When_WarriorHasNotEnrolled_ShouldThrowAnException()
        {
            Warrior warrior = new("Gosho", 40, 100);
            Warrior enemy = new("Viki", 50, 100);

            arena.Enroll(enemy);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior.Name, enemy.Name));
            Assert.AreEqual($"There is no fighter with name {warrior.Name} enrolled for the fights!", exception.Message);
        }

        [Test]
        public void When_EnemyHasNotEnrolled_ShouldThrowAnException()
        {
            Warrior warrior = new("Gosho", 40, 100);
            Warrior enemy = new("Viki", 50, 100);

            arena.Enroll(warrior);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior.Name, enemy.Name));
            Assert.AreEqual($"There is no fighter with name {enemy.Name} enrolled for the fights!", exception.Message);
        }
    }
}
