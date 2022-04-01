﻿using NUnit.Framework;
using Search;

namespace SearchTests
{
    [TestFixture]
    public class SearchJumperTests
    {
        private static int[] _array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,17,18,19,20 };
        
        [Test]
        public void Binary_Find1_From1To20()
        {
            int result = FindElement.JumpSearch(_array, 1);
            
            Assert.AreEqual(result, 0);
        }
        
        [Test]
        public void Binary_Find16_From1To20()
        {
            int result = FindElement.JumpSearch(_array, 20);
            
            Assert.AreEqual(result, 19);
        }
        
        [Test]
        public void Binary_Find0_From1To20()
        {
            int result = FindElement.JumpSearch(_array, 0);
            
            Assert.AreEqual(result, -1);
        }
        
        [Test]
        public void Binary_Find17_From1To20()
        {
            int result = FindElement.JumpSearch(_array, 21);
            
            Assert.AreEqual(result, -1);
        }
    }
}