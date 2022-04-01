using NUnit.Framework;
using Search;

namespace SearchTests
{
    [TestFixture]
    public class SearchLinearWithBarrierTests
    {
        private static int[] _array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 0};

        [Test]
        public void LinearWithBarrier_Find1_From1To20()
        {
            _array[20] = 1;

            int result = FindElement.SearchWithBarrier(_array, 1);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void LinearWithBarrier_Find20_From1To20()
        {
            _array[20] = 20;

            int result = FindElement.SearchWithBarrier(_array, 20);

            Assert.AreEqual(result, 19);
        }

        [Test]
        public void LinearWithBarrier_Find0_From1To20()
        {
            _array[20] = 0;

            int result = FindElement.SearchWithBarrier(_array, 0);

            Assert.AreEqual(result, -1);
        }

        [Test]
        public void LinearWithBarrier_Find21_From1To20()
        {
            _array[20] = 21;

            int result = FindElement.SearchWithBarrier(_array, 21);

            Assert.AreEqual(result, -1);
        }
    }
}