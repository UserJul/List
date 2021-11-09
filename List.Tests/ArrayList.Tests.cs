using NUnit.Framework;

namespace ArrayList.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        public void AddLastTest(int[] array, int value, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.AddLast(value);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, new int[4] { 1, 2, 3, 4 }, new int[5] { 1, 2, 5, 3, 4 })]
        [TestCase(1, 4, new int[3] { 1, 2, 3 }, new int[4] { 1, 4, 2, 3 })]
        public void AddAtTest(int index, int value, int[] array, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.AddAt(index, value);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void AddLastTestList(int[] array, int[] list, int[] expected)
        {
            List arrayList = new List(array);
            List arrayList1 = new List(list);
            arrayList.AddLast(arrayList1);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[3] { 1, 2, 3 }, 1, new int[] { 4, 5 }, new int[] { 1, 4, 5, 2, 3, })]
        public void AddAtTestList(int[] array, int idx, int[] array1, int[] expected)
        {
            List arrayList = new List(array);
            List arrayList1 = new List(array1);
            arrayList.AddAt(idx, arrayList1);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 5, 1, 2, 3, 4 })]
        public void AddFirstTest(int[] array, int value, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.AddFirst(value);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[6] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[3] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5, 6 }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5, 6, 4, 5, 6 })]
        [TestCase(new int[] { 4, 5, 6 }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[3] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void AddFirstListTest(int[] array, int[] list, int[] newArray)
        {
            List arrayList = new List(array);
            List arrayList1 = new List(list);
            arrayList.AddFirst(arrayList1);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(newArray, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        public void RemoveFirstTest(int[] array, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.RemoveFirst();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 0, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 2, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 3, 2, 3, 4 }, 3, 1, new int[] { 1, 2, 3, 4 })]
        public void RemoveFirst(int[] array, int val, int index, int[] expected)
        {
            List arrayList = new List(array);
            int idx = arrayList.RemoveFirst(val);

            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(index, idx);
        }

        [TestCase(new int[3] { 1, 2, 3 }, new int[2] { 1, 2 })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.RemoveLast();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[3] { 1, 2, 3 }, 1, new int[2] { 1, 3 })]
        public void RemoveAtTest(int[] array, int index, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.RemoveAt(index);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] { 1, 2, 3, 4 }, 2, new int[2] { 3, 4 })]
        public void RemoveFirstMultipleTest(int[] array, int n, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.RemoveFirstMultiple(n);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] { 1, 2, 3, 4 }, 2, new int[2] { 1, 2 })]
        public void RemoveLasttMultipleTest(int[] array, int n, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.RemoveLastMultiple(n);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 2, 2, new int[3] { 1, 2, 5 })]
        public void RemoveAtMultipleTest(int[] array, int index, int n, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.RemoveAtMultiple(index, n);
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 2, 1)]
        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 6, -1)]
        public void IndexOfTest(int[] array, int value, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.IndexOf(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        public void GetFirstTest(int[] array, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.GetFirst();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void GetLastTest(int[] array, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.GetLast();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 5)]
        public void GetTest(int[] array, int index, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.Get(index);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        public void ReverseTest(int[] array, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.Reverse();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void MaxTest(int[] array, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.Max();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        public void MinTest(int[] array, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.Min();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.IndexOfMax();
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            List arrayList = new List(array);
            int actual = arrayList.IndexOfMin();
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        public void SortTest(int[] array, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.Sort();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void SortDesTest(int[] array, int[] expected)
        {
            List arrayList = new List(array);
            arrayList.SortDes();
            int[] actual = arrayList.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}