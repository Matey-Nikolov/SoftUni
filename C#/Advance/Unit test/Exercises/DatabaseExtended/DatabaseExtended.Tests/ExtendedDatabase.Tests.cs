using NUnit.Framework;
using P02_ExtendedDatabase;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        /*
        [SetUp]
        public void Setup()
        {
        }
        */
        [Test]
        public void Test_FindById()
        {
            ExtendedDatabase database = new ExtendedDatabase();
            Person personFind1 = new Person(1, "Nikola");
            Person personFind2 = new Person(2, "Niko");

            database.Add(personFind1);
            database.Add(personFind2);

            Assert.That(() => database.FindById(-1), Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => database.FindById(3), Throws.InstanceOf<InvalidOperationException>());
            Assert.That(database.FindById(2).Id, Is.EqualTo(personFind2.Id));
        }

        [Test]
        public void Test_FindByUsername()
        {
            ExtendedDatabase database = new ExtendedDatabase();
            Person personFind1 = new Person(1, "Nikola");
            Person personFind2 = new Person(2, "Niko");

            database.Add(personFind1);
            database.Add(personFind2);

            Assert.That(() => database.FindByUsername(""), Throws.InstanceOf<ArgumentNullException>());
            Assert.That(() => database.FindByUsername("niko"), Throws.InstanceOf<InvalidOperationException>());
            Assert.That(database.FindByUsername("Nikola").UserName, Is.EqualTo(personFind1.UserName));
        }

        [Test]
        public void Test_Remove()
        {
            ExtendedDatabase databaseForRemove = new ExtendedDatabase();
            
            Person person = new Person(1, "Matey");

            databaseForRemove.Add(person);
            databaseForRemove.Remove();

            Assert.That(() => databaseForRemove.Remove(), Throws.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void Test_Add()
        {
            // 1
            /*
            ExtendedDatabase databaseCountLimit = new ExtendedDatabase();

            Person countPerson1 = new Person(1, "q");
            Person countPerson2 = new Person(2, "qw");
            Person countPerson3 = new Person(3, "qqwe");
            Person countPerson4 = new Person(4, "qq");
            Person countPerson5 = new Person(5, "q2");
            Person countPerson6 = new Person(6, "q3");
            Person countPerson7 = new Person(7, "q4");
            Person countPerson8 = new Person(8, "q5");
            Person countPerson9 = new Person(9, "q6");
            Person countPerson10 = new Person(10, "q7");
            Person countPerson11 = new Person(11, "q8");
            Person countPerson12 = new Person(12, "q9");
            Person countPerson13 = new Person(13, "q56");
            Person countPerson14 = new Person(14, "q56wewe");
            Person countPerson15 = new Person(15, "q34");
            Person countPerson16 = new Person(16, "32456q");

            databaseCountLimit.Add(countPerson1);
            databaseCountLimit.Add(countPerson2);
            databaseCountLimit.Add(countPerson3);
            databaseCountLimit.Add(countPerson5);
            databaseCountLimit.Add(countPerson6);
            databaseCountLimit.Add(countPerson7);
            databaseCountLimit.Add(countPerson8);
            databaseCountLimit.Add(countPerson9);
            databaseCountLimit.Add(countPerson10);
            databaseCountLimit.Add(countPerson11);
            databaseCountLimit.Add(countPerson13);
            databaseCountLimit.Add(countPerson14);
            databaseCountLimit.Add(countPerson15);
            databaseCountLimit.Add(countPerson16);
            Person countPerson17 = new Person(17, "123q");
            //Person countPerson18 = new Person(18, "789465");
            //databaseCountLimit.Add(countPerson17);

            //Assert.That(() => databaseCountLimit.Add(countPerson17), Throws.InstanceOf<InvalidOperationException>());
            */
            
            // 2
            ExtendedDatabase databaseForUniqueUsername = new ExtendedDatabase();
            Person personUsername = new Person(1, "Matey");
            databaseForUniqueUsername.Add(personUsername);
            Person testPersonUsername = new Person(2, "Matey");
            Assert.That(() => databaseForUniqueUsername.Add(testPersonUsername), Throws.InstanceOf<InvalidOperationException>());
            
            // 3
            ExtendedDatabase databaseForUniqueId = new ExtendedDatabase();
            Person personId = new Person(1, "Matey");
            databaseForUniqueId.Add(personId);
            Person testPersonId = new Person(1, "Nikola");
            
            Assert.That(() => databaseForUniqueId.Add(testPersonId), Throws.InstanceOf<InvalidOperationException>());

        }

    }
}