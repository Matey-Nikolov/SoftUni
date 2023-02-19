using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
//using P04_FightingArena;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test_Attack_HP()
        {
            //Work

            Warrior warriorAttack = new Warrior("Viktor", 20, 80);
            Warrior testWarriorDeff = new Warrior("Stili", 10, 40);

            warriorAttack.Attack(testWarriorDeff);
            Assert.That(warriorAttack.HP, Is.EqualTo(70));

            warriorAttack = new Warrior("Viktor", 42, 40);
            testWarriorDeff = new Warrior("Stili", 10, 40);

            warriorAttack.Attack(testWarriorDeff);
            Assert.That(testWarriorDeff.HP, Is.EqualTo(0));
        }

        [Test]
        public void Test_Attack_Exceptions()
        {
            Warrior warriorAttack = new Warrior("Viktor", 34, 40);
            Warrior testWarriorAttack = new Warrior("Stili", 10, 30);

            //Exceptions
            
              Assert.That(() => testWarriorAttack.Attack(warriorAttack), Throws.InstanceOf<InvalidOperationException>(), "Your HP is too low in order to attack other warriors!");
              Assert.That(() => warriorAttack.Attack(testWarriorAttack), Throws.InstanceOf<InvalidOperationException>(), "Enemy HP must be greater than 30 in order to attack him!");
        }

        [Test]
        public void Test_HP()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior testHPProperty = new Warrior("Stili", 3, -6);
            });
        }

        [Test]
        public void Test_Damage()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior testDamageProperty = new Warrior("Stili", 0, 2);
            });
        }

        [Test]
        public void Test_Name()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior testNameProperty = new Warrior("", 3, 2);
            });
        }

        [Test]
        public void Test_Constructor()
        {
            Warrior warrior = new Warrior("Matey", 23, 50);
            Warrior testWarrior = new Warrior("Matey", 23, 50);

            Assert.AreEqual(warrior.Name, testWarrior.Name);
            Assert.AreEqual(warrior.Damage, testWarrior.Damage);
            Assert.AreEqual(warrior.HP, testWarrior.HP);
        }
    }
}