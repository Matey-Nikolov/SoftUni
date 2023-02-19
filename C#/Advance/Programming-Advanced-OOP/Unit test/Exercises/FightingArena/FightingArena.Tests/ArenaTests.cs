using NUnit.Framework;
//using P04_FightingArena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Tests
{
    public class ArenaTests
    {
        //private List<Warrior> warriors;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Fight_Exception()
        {
            Arena arena = new Arena();

            List<Warrior> newWarriors = new List<Warrior>
            {
                new Warrior("Stili", 120, 400),
                new Warrior("Viktor", 60, 60),
                new Warrior("Matey", 180, 380)
            };

            foreach (var item in newWarriors)
            {
                arena.Enroll(item);
            }

            Assert.That(() => arena.Fight("Ok", "Viktor"), Throws.InstanceOf<InvalidOperationException>(), "There is no fighter with name Ok enrolled for the fights!");
            Assert.That(() => arena.Fight("Viktor", "Stili1"), Throws.InstanceOf<InvalidOperationException>(), "There is no fighter with name Stili1 enrolled for the fights!");
        }

        [Test]
        public void Test_Fight_Work()
        {
            Arena arena = new Arena();

            List<Warrior> newWarriors = new List<Warrior>
            {
                new Warrior("Stili", 120, 400),
                new Warrior("Viktor", 60, 60),
                new Warrior("Matey", 180, 380)
            };

            foreach (var item in newWarriors)
            {
                arena.Enroll(item);
            }

            arena.Fight("Stili", "Matey");


            foreach (var item1 in newWarriors)
            {
                if (item1.Name == "Matey")
                {
                    //260
                    Assert.That(item1.HP, Is.EqualTo(260));
                }
            }
        }

        [Test]
        public void Test_Warriors_Count()
        {
            Arena arena = new Arena();

            List<Warrior> newWarriors = new List<Warrior>
            {
                new Warrior("Stili", 120, 60),
                new Warrior("Viktor", 60, 60),
                new Warrior("Matey", 180, 380)
            };

            foreach (var item in newWarriors)
            {
                arena.Enroll(item);
            }

            Assert.That(() => arena.Count, Is.EqualTo(3));
        }

        [Test]
        public void Test_Enroll()
        {
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Thor", 180, 380);


            List<Warrior> newWarriors = new List<Warrior>
            {
                new Warrior("Achilles", 120, 60),
                new Warrior("Hector", 60, 60),
                new Warrior("Thor", 180, 380)
            };

            foreach (var item in newWarriors)
            {
                arena.Enroll(item);
            }

            Assert.That(() => arena.Enroll(warrior), Throws.InstanceOf<InvalidOperationException>(), "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void Test_Constructor()
        {
            Arena arena = new Arena();
            
            List<Warrior> newList = new List<Warrior>
            {
                new Warrior("Achilles", 120, 240),
                new Warrior("Hector", 130, 260),
                new Warrior("Thor", 180, 360)
            };

            foreach (var warrior in newList)
            {
                arena.Enroll(warrior);
            }
        }
    }
}