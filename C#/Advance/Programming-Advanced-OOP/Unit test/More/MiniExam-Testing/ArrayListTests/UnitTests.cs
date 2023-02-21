using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnitTesting;

namespace ArrayListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ArrayList_Change_Ok()
        {
            ArrayList testList = new ArrayList();
            testList.Add(1); // 0
            testList.Add(2); // 1
            testList.Add(3);// 2
            testList.Add(4); // 3

            int index = testList.Change(2, 192);
            
            Assert.AreEqual(1, index);

            index = testList.Change(5, 23);
            Assert.AreEqual(-1, index);
        }

        [Test]
        public void Test_ArrayList_Cut_ArgumentOutOfRangeException()
        {
            ArrayList list = new ArrayList();
            list.Add(1); // 0
            list.Add(2); // 1
            list.Add(3);// 2
            list.Add(4); // 3

            Assert.That(() => list.Cut(6), Throws.InstanceOf<ArgumentOutOfRangeException>(), "Number is out of range.");
        }

        [Test]
        public void Test_ArrayList_Cut()
        {
            ArrayList list = new ArrayList();
           // list.Add('1'); // 0
           // list.Add('2'); // 1
            list.Add(1); // 0
            list.Add(2); // 1
            list.Add(3);// 2
            list.Add(4); // 3

            // count = 4
            // cut = 2 
            // 4 - 2 = 2
            list.Cut(2);
            Assert.AreEqual(2, list.Count);

        }

        [Test]
        public void Test_ArrayList_CountFreePositions()
        {
            ArrayList list = new ArrayList();
            list.Add(1); // 0
            list.Add(2); // 1
            list.Add(3); // 2 , 3

            // Initial_Capacity = 2 * 2 = 4

            // 3
            // 2 * 2 = 4
            // 4 - 3 = 1

            Assert.AreEqual(1, list.CountFreePositions());

            // 4 - 4 = 0
            list.Add(4);
            Assert.AreEqual(0, list.CountFreePositions());

            // 4 * 2 = 8 - 5 = 3
            list.Add(5);
            Assert.AreEqual(3, list.CountFreePositions());
        }

        [Test]
        public void Test_ArrayList_Add()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //Assert.AreEqual(4, list.Count);
            Assert.That(list.Count == 3);

        }

        [Test]
        public void Test_ArrayList_Constructor()
        {
            ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);

            Assert.IsNotNull(arrayList.Count);
        }

    }
}