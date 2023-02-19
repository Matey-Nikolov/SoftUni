namespace Collections.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Transactions;

    public class CircularQueueTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_CircularQueue_1MilionItems()
        {
            const int iterationsCount = 1000000;

            var queue = new CircularQueue<int>();

            int addedCount = 0;
            int removedCount = 0;
            int counter = 0;

            for (int i = 0; i < iterationsCount; i++)
            {
                queue.Enqueue(++counter);
                addedCount++;

                queue.Enqueue(++counter);
                addedCount++;

                queue.Dequeue();
                removedCount++;
            }
            
            Assert.That(queue.Count == addedCount - removedCount);
        }

        [Test]
        public void Test_CircularQueue_MultipleOperations()
        {
            const int initialCapacity = 2;
            const int iterationsCount = 300;

            var queue = new CircularQueue<int>(initialCapacity);

            int addedCount = 0;
            int removedCount = 0;
            int counter = 0;

            for (int i = 0; i < iterationsCount; i++)
            {
                Assert.That(queue.Count == addedCount - removedCount);

                queue.Enqueue(++counter);
                addedCount++;
                Assert.That(queue.Count == addedCount - removedCount);

                queue.Enqueue(++counter);
                addedCount++;
                Assert.That(queue.Count == addedCount - removedCount);

                var firstElement = queue.Peek();
                Assert.That(firstElement == removedCount + 1);

                var removedElement = queue.Dequeue();
                removedCount++;
                Assert.That(removedElement == removedCount);
                Assert.That(queue.Count == addedCount - removedCount);
            }

            var expectedElements = Enumerable
                    .Range(removedCount + 1, addedCount - removedCount)
                    .ToArray();

            var expectedStr = "[" + string.Join(", ", expectedElements) + "]";

            var queueAsArray = queue.ToArray();
            var queueString = queue.ToString();

            CollectionAssert.AreEqual(expectedElements, queueAsArray);
            Assert.AreEqual(expectedStr, queueString);

            Assert.That(queue.Capacity >= queue.Count);


            Assert.That(queue.Count > initialCapacity);

        }

        [Test]
        public void Test_CircularQueue_EnqueueDequeue_WhitRangeCross()
        {
            var queue = new CircularQueue<int>(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var firstElement = queue.Dequeue();
            Assert.That(firstElement, Is.EqualTo(10));

            var seconfElement = queue.Dequeue();
            Assert.That(seconfElement, Is.EqualTo(20));

            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);

            Assert.That(queue.ToString() == "[30, 40, 50, 60]");
            Assert.That(queue.Count == 4);
            Assert.That(queue.Capacity == 5);
            Assert.That(queue.StartIndex > queue.EndIndex);
        }

        [Test]
        public void Test_CircularQueue_ToString()
        {
            var queue = new CircularQueue<string>();

            queue.Enqueue("10");
            queue.Enqueue("20");
            queue.Enqueue("30");

            var array = queue.ToArray();

            CollectionAssert.AreEqual(new string[] { "10", "20", "30" }, array);
        }

        [Test]
        public void Test_CircularQueue_ToArray()
        {
            var queue = new CircularQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var array = queue.ToArray();

            CollectionAssert.AreEqual(new int[] { 10, 20, 30 }, array);
        }

        [Test]
        public void Test_CircularQueue_PeekEmpty()
        {
            var queue = new CircularQueue<int>(5);

            queue.Enqueue(10);
            queue.Dequeue();

            Assert.That(() => queue.Peek(), Throws.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void Test_CircularQueue_Peek()
        {
            CircularQueue<string> queue = new CircularQueue<string>();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            string peek = queue.Peek();

            Assert.That(peek.ToString() == "A");
        }

        [Test]
        public void Test_CircularQueue_DequeueEmpty()
        {
            var queue = new CircularQueue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.That(() => queue.Dequeue(), Throws.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void Test_CircularQueue_Dequeue()
        {
            var queue = new CircularQueue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
 
            queue.Dequeue();

            Assert.That(queue.ToString() == "[B, C]");
            //Assert.That(queue.Count == 3);
            //Assert.That(queue.Capacity >= queue.Count);
        }

        [Test]
        public void Test_CircularQueue_ConstructorWithCapacity()
        {
            var queue = new CircularQueue<int>(2);

            queue.Enqueue(2);

            Assert.That(queue.Capacity == 2);
            Assert.That(queue.StartIndex == 0);
        }

        [Test]
        public void Test_CircularQueue_ConstructorDefault()
        {
            var queue = new CircularQueue<int>();

            Assert.That(queue.ToString() == "[]");
            Assert.That(queue.Count == 0);
            Assert.That(queue.Capacity > 0);
            Assert.That(queue.StartIndex == 0);
            Assert.That(queue.EndIndex == 0);
        }
    }
}