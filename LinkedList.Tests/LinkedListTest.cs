using NUnit.Framework;

namespace LinkedList.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        public void GetLengthTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.GetLength();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        public void AddLastLinkedTest(int[] array, int value, int[] expectedArray)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.AddLast(value);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expectedArray, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        public void AddFirstLinkedTest(int[] array, int value, int[] expectedArray)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.AddFirst(value);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expectedArray, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 1, 4, new int[] { 1, 4, 2, 3 })]
        public void AddAtLinkedTest(int[] array, int index, int value, int[] expectedArray)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.AddAt(index, value);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expectedArray, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        public void RemoveFirstTest(int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirst();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, new int[] { 1, 2, 3, 5, 6 })]
        [TestCase(new int[] { 3, 3, 3 }, 3, new int[] { 3, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 5, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, 2, new int[] { 1, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { 1, 2 })]
        public void RemoveFirstValueTest(int[] array, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirst(value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 2, 3 })]
        public void RemoveAtTest(int[] array, int index, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveAt(index);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, new int[] { 1, 2 })]
        public void RemoveLastMultipleLinkidListTest(int[] array, int n, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveLastMultiple(n);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
      
        [TestCase(new int[] { 3, 3, 3 }, 1, 2, new int[] { 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, 1, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, 1, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, 3, new int[] { })]
        public void RemoveAtMultipleLinkidListTest(int[] array, int index, int n, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveAtMultiple(index, n);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(new int[] { 3, 3, 3 }, 1, new int[] { 3, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { })]
        public void RemoveFirstMultipleLinkidListTest(int[] array, int n, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveFirstMultiple(n);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(new int[] { 1, 2, 3 }, 1, 5, new int[] { 1, 5, 3 })]
        public void SetTest(int[] array, int index, int value, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.Set(index, value);
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void RemoveLastTest(int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            actual.RemoveLast();
            LinkedList expected = new LinkedList(expectedArray);
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
    }
}