using NUnit.Framework;
using Search;

namespace SearchTests
{
    [TestFixture]
    public class SearchLinearTests
    {
        private static int[] _array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,17,18,19,20 };
        
        [Test]
        public void Binary_Find1_From1To20()
        {
            int result = FindElement.LinearSearch(_array, 1);
            
            Assert.AreEqual(result, 0);
        }
        
        [Test]
        public void Binary_Find20_From1To20()
        {
            int result = FindElement.LinearSearch(_array, 20);
            
            Assert.AreEqual(result, 19);
        }
        
        [Test]
        public void Binary_Find0_From1To20()
        {
            int result = FindElement.LinearSearch(_array, 0);
            
            Assert.AreEqual(result, -1);
        }
        
        [Test]
        public void Binary_Find21_From1To20()
        {
            int result = FindElement.LinearSearch(_array, 21);
            
            Assert.AreEqual(result, -1);
        }
    }
}