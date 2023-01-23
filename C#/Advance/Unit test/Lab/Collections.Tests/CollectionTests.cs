namespace Collections.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    public class CollectionTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            // Arrange
            var nums = new Collection<int>();
            // Assert
            Assert.That(nums.ToString(), Is.EqualTo("[]"));
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            var nums = new Collection<int>(5);
            Assert.That(nums.ToString(), Is.EqualTo("[5]"));
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            var nums = new Collection<int>(5, 10, 15);
            Assert.That(nums.ToString(), Is.EqualTo("[5, 10, 15]"));
        }

        [Test]
        public void Test_Collections_Add()
        {
            // Arrange
            var nums = new Collection<int>();

            // Act
            nums.Add(5);
            nums.Add(6);

            // Assert
            Assert.That(nums.ToString(), Is.EqualTo("[5, 6]"));

        }

        [Test]
        public void Test_Collection_AddRangeWithGrow()
        {
            var nums = new Collection<int>();
            int oldCapacity = nums.Capacity;
            var newNums = Enumerable.Range(1000, 2000).ToArray();
            nums.AddRange(newNums);
            string expectedNums = "[" + string.Join(", ", newNums) + "]";

            Assert.That(nums.ToString(), Is.EqualTo(expectedNums));
            Assert.That(nums.Capacity,
            Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            // Arrange
            var names = new Collection<string>("Peter", "Maria");

            // Act
            var item0 = names[0];
            var item1 = names[1];

            // Assert
            Assert.That(item0, Is.EqualTo("Peter"));
            Assert.That(item1, Is.EqualTo("Maria"));
        }

        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var names = new Collection<string>("Bob", "Joe");

            Assert.That(() => { var name = names[-1]; },
            Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var name = names[2]; },
            Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var name = names[500]; },
            Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(names.ToString(), Is.EqualTo("[Bob, Joe]"));
        }

        [Test]
        public void Test_Collection_ToStringNestedCollections()
        {
            var names = new Collection<string>("Teddy", "Gerry");
            var nums = new Collection<int>(10, 20);
            var dates = new Collection<DateTime>();
            var nested = new Collection<object>(names, nums, dates);
            string nestedToString = nested.ToString();

            Assert.That(nestedToString,
            Is.EqualTo("[[Teddy, Gerry], [10, 20], []]"));
        }

        [Test]
        [Timeout(1000)]
        public void Test_Collection_1MillionItems()
        {
            const int itemsCount = 1000000;
            var nums = new Collection<int>();

            nums.AddRange(Enumerable.Range(1, itemsCount).ToArray());

            Assert.That(nums.Count == itemsCount);
            Assert.That(nums.Capacity >= nums.Count);

            for (int i = itemsCount - 1; i >= 0; i--)
                nums.RemoveAt(i);

            Assert.That(nums.ToString() == "[]");
            Assert.That(nums.Capacity >= nums.Count);

        }

        [Test]
        public void Test_Collection_AddRange()
        {
            var numbers = new Collection<int>(1, 2, 3, 4);

            int[] insert = { 10, 23, 23 };

            numbers.AddRange(insert);

            Assert.That(numbers.ToString(), Is.EqualTo("[1, 2, 3, 4, 10, 23, 23]"));
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {

        }

        [Test]
        public void Test_Collection_SetByInvalidIndex()
        {
        
        }

        [Test]
        public void Test_Collection_InsertAtStart()
        {
            var numbers = new Collection<int>(1, 2, 3, 4);

            int insert = 10;

            numbers.InsertAt(0, insert);

            Assert.That(numbers.ToString(), Is.EqualTo("[10, 1, 2, 3, 4]"));
        }

        [Test]
        public void Test_Collection_InsertAtEnd()
        {
            var numbers = new Collection<int>(1, 2, 3, 4);

            int insert = 10;

            numbers.InsertAt(numbers.Count, insert);

            Assert.That(numbers.ToString(), Is.EqualTo("[1, 2, 3, 4, 10]"));
        }

        [Test]
        public void Test_Collection_InsertAtMiddle()
        {
            var numbers = new Collection<int>(1, 2, 3, 4);

            int insert = 10;

            numbers.InsertAt(numbers.Count / 2, insert);

            //Assert.That(names, Is.EqualTo("[10, 1, 2, 3, 4]"));
            Assert.That(numbers.ToString(), Is.EqualTo("[1, 2, 10, 3, 4]"));
        }

        [Test]
        public void Test_Collection_InsertAtWithGrow()
        {

        }

        [Test]
        public void Test_Collection_InsertAtInvalidIndex()
        {
        
        }

        [Test]
        public void Test_Collection_ExchangeMiddle()
        {
            var numbers = new Collection<int>(1, 2, 3, 4);

            numbers.Exchange(1, 2);

            Assert.That(numbers.ToString(), Is.EqualTo("[1, 3, 2, 4]"));
        }

        [Test]
        public void Test_Collection_ExchangeFirstLast()
        {
            var names = new Collection<string>("Matey", "Nikola", "Maria");

            names.Exchange(0, names.Count - 1);

            Assert.That(names.ToString(), Is.EqualTo("[Maria, Nikola, Matey]"));
        }

        [Test]
        public void Test_Collection_ExchangeInvalidIndexes()
        {
            var names = new Collection<string>("Matey", "Nikola", "Maria");

            names.Exchange(-1, names.Count - 1);

            Assert.That(() => names.ToString(), Throws.InstanceOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void Test_Collection_RemoveAtStart()
        {
            var names = new Collection<string>("Peter", "Maria", "Steve", "Mia");

            var removed = names.RemoveAt(0);

            Assert.That(removed, Is.EqualTo("Peter"));
            Assert.That(names.ToString(), Is.EqualTo("[Maria, Steve, Mia]"));
        }

        [Test]
        public void Test_Collection_RemoveAtEnd()
        {
            var names = new Collection<string>("Peter", "Maria", "Steve", "Mia");

            var removed = names.RemoveAt(names.Count - 1);

            Assert.That(removed, Is.EqualTo("Mia"));
            Assert.That(names.ToString(), Is.EqualTo("[Peter, Maria, Steve]"));
        }

        [Test]
        public void Test_Collection_RemoveAtMiddle()
        {
            var names = new Collection<string>("Peter", "Maria", "Steve", "Mia");

            var removed = names.RemoveAt(1);

            Assert.That(removed, Is.EqualTo("Maria"));
            Assert.That(names.ToString(), Is.EqualTo("[Peter, Steve, Mia]"));
        }

        // !!!!!!!!!!!!!!!!!!!!!1
        [Test]
        public void Test_Collection_RemoveAtInvalidIndex()
        {
            var names = new Collection<string>("Peter", "Maria", "Steve", "Mia");

            //names.RemoveAt(-1);

            Assert.That( () => names.RemoveAt(-1), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Test_Collection_RemoveAll()
        {
            var names = new Collection<string>("Peter", "Maria", "Steve", "Mia");

            names.Clear();

            Assert.That(names.ToString(), Is.EqualTo("[]"));
        }

        [Test]
        public void Test_Collection_Clear()
        {
            var names = new Collection<string>("Peter", "Maria", "Steve", "Mia");

            names.Clear();

            Assert.That(names.ToString(), Is.EqualTo("[]"));
            // Assert.That(names.ToString(), Is.EqualTo("[Peter, Steve, Mia]"));
        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var names = new Collection<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.That(names.Count, Is.EqualTo(16));
            Assert.That(names.Capacity, Is.EqualTo(32));
        }

        [Test]
        public void Test_Collection_ToStringEmpty()
        {
            var empty = new Collection<string>("");

            empty.ToString();

            Assert.That(empty.ToString(), Is.EqualTo("[]"));
        }

        [Test]
        public void Test_Collection_ToStringSingle()
        {
            var single = new Collection<string>("k");

            single.ToString();

            Assert.That(single.ToString(), Is.EqualTo("[k]"));
        }

        [Test]
        public void Test_Collection_ToStringMultiple()
        {
            var multiple = new Collection<string>("k, o");

            multiple.ToString();

            Assert.That(multiple.ToString(), Is.EqualTo("[k, o]"));
        }
    }
}