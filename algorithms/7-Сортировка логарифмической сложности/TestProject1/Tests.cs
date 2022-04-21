using ConsoleApplication1;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        int[] _array = {5, 0, 4, 1, 0, 15, 25, 10, 9, 8, 1};
        int[] expectedArray = {0, 0, 1, 1, 4, 5, 8, 9, 10, 15, 25};
        
        [Test]
        public void QuickSortTest()
        {
            _array = SortAlgorithm.QuickSort(_array,0,_array.Length-1);

            Assert.AreEqual(_array, expectedArray);
        }
        
        [Test]
        public void MergeSortTest()
        {
            _array = SortAlgorithm.MergeSort(_array,0,_array.Length-1);

            Assert.AreEqual(_array, expectedArray);
        }

        [Test]
        public void HeapSortTest()
        {
            SortAlgorithm.HeapSort(_array);

            Assert.AreEqual(_array, expectedArray);
        }
    }
}