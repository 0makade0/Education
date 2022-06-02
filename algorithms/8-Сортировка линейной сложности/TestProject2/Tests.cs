using System.Collections.Generic;
using LinearSort;
using NUnit.Framework;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        int[] _array = {5, 0, 4, 1, 0, 15, 25, 10, 9, 8, 1};
        int[] expectedArray = {0, 0, 1, 1, 4, 5, 8, 9, 10, 15, 25};

        int[] arr = {43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4};
        private List<int> _sorted = new List<int>(){4, 6, 13, 17, 31, 43, 62, 66, 87, 92, 96};

        [Test]
        public void CoutingSort()
        {
            _array = Sort.CountingSort(_array);

            Assert.AreEqual(_array, expectedArray);
        }

        [Test]
        public void PigeonholeSort()
        {
            _array = Sort.PigeonholeSort(_array);

            Assert.AreEqual(_array, expectedArray);
        }

        [Test]
        public void BucketSort()
        {
            List<int> sortedArray = Sort.BucketSort(arr);

            Assert.AreEqual(sortedArray, _sorted);
        }
        
        [Test]
        public void RadixSort()
        {
            Sort.RadixSort(_array,_array.Length);

            Assert.AreEqual(_array, expectedArray);
        }
    }
}