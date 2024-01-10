namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private const int MIN_ATTACK_HP = 30;

        [Test]
        public void When_CreatingANewWarrior_Data_ShouldBeSetCorrectly()
        {
            Warrior warroir = new Warrior("Gosho", 10, 100);

            Assert.AreEqual("Gosho", warroir.Name);
            Assert.AreEqual(10, warroir.Damage);
            Assert.AreEqual(100, warroir.HP);
        }

        [TestCase("")]
        [TestCase(null)]
        public void When_NameIsEmptyOrWhiteSpace_ShouldThrowAnException(string name)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Warrior(name, 10, 100));

            Assert.AreEqual("Name should not be empty or whitespace!", exception.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void When_DamageIsZeroOrNegative_ShouldThrowAnException(int damage)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Warrior("Gosho", damage, 100));

            Assert.AreEqual("Damage value should be positive!", exception.Message);
        }

        [TestCase(-20)]
        [TestCase(-1)]
        public void When_HPIsNegative_ShouldThrowAnException(int hp)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Warrior("Gosho", 10, hp));

            Assert.AreEqual("HP should not be negative!", exception.Message);
        }

        [Test]
        public void When_AttackingEnemy_Data_ShouldChangeCorrectly()
        {
            Warrior warroirOne = new Warrior("Pesho", 40, 90);
            Warrior enemy = new Warrior("Gosho", 50, 100);

            warroirOne.Attack(enemy);

            Assert.AreEqual(40, warroirOne.HP);
            Assert.AreEqual(60, enemy.HP);
        }

        [Test]
        public void When_WarriorIsWithLessHpThanNeeded_ShouldThrowException()
        {
            Warrior warroirOne = new Warrior("Pesho", 40, 20);
            Warrior enemy = new Warrior("Gosho", 50, 100);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => warroirOne.Attack(enemy));

            Assert.AreEqual("Your HP is too low in order to attack other warriors!", exception.Message);
        }

        [Test]
        public void When_EnemyIsWithLessHpThanNeeded_ShouldThrowException()
        {
            Warrior warroirOne = new Warrior("Pesho", 40, 90);
            Warrior enemy = new Warrior("Gosho", 50, 10);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => warroirOne.Attack(enemy));

            Assert.AreEqual($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!", exception.Message);
        }

        [Test]
        public void When_EnemyAttackIsMoreThanWarriorXp_ShouldThrowException()
        {
            Warrior warroirOne = new Warrior("Pesho", 40, 40);
            Warrior enemy = new Warrior("Gosho", 50, 100);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => warroirOne.Attack(enemy));

            Assert.AreEqual("You are trying to attack too strong enemy", exception.Message);
        }

        [Test]
        public void When_WarriorAttackIsMoreThanEnemyHp_Data_ShouldChangeCorrectly()
        {
            Warrior warroirOne = new Warrior("Pesho", 50, 90);
            Warrior enemy = new Warrior("Gosho", 50, 40);

            warroirOne.Attack(enemy);

            Assert.AreEqual(40, warroirOne.HP);
            Assert.AreEqual(0, enemy.HP);
        }
    }
}