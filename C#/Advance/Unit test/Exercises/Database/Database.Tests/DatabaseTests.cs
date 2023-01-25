using NUnit.Framework;
using P01_Database;
using System;


namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Database_Fetch()
        { 
            var db1 = new Database(1, 2, 3, 4, 5, 6);
            int[] db2 = new int[] { 1, 2, 3, 4, 5, 6 };

            int[] actualResult = db1.Fetch();
            CollectionAssert.AreEqual(db2, actualResult);
        }

        [Test]
        public void Test_Database_Remove()
        {
            var db = new Database();

            for (int i = 0; i < 5; i++)
            {
                db.Add(i);
            }

            for (int i = 0; i < 5; i++)
            {
                db.Remove();
            }

            Assert.That(() => db.Remove(), Throws.InstanceOf<InvalidOperationException>());


            db.Add(3);
            db.Add(4);
            db.Remove();
            Assert.AreEqual(1, db.Count);
        }

        [Test]
        public void Test_Database_Add_Size()
        {
            var db = new Database();

            for (int i = 0; i < 16; i++)
            {
                db.Add(i);
            }

            Assert.That(() => db.Add(17), Throws.InstanceOf<InvalidOperationException>());
        }

        
        [Test]
        public void Test_Database_Sorting()
        {
            var db = new Database();

            Assert.That(() => db.Count != 16, Throws.InstanceOf<InvalidOperationException>());
        }
        

        [Test]
        public void Test_Database_Constructor()
        {
            // Arrange
            var nums1 = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var nums2 = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            int[] numbersTest = new int[16];

            for (int i = 1; i < 15; i++)
            {
                numbersTest[i] = i;
            }

           // CollectionAssert.AreEqual(numbersTest, nums);

        }
    }
}