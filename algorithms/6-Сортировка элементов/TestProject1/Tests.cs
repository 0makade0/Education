using NUnit.Framework;
using SortArrayAlgorithm;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BubbleSortTest()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.BubbleSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        public void ShakerSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.ShakerSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        [Test]
        public void ComboSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.ComboSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        [Test]
        public void OddEvenSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.OddEvenSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        [Test]
        public void ChoiseSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.ChoiseSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        [Test]
        public void InstertSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.InstertSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        [Test]
        public void ShellSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.ShellSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        [Test]
        public void GnomSort()
        {
            int[] array ={5,0,4,1,0,15,25,10,9,8,1};
            int[] expectedArray = { 0,0,1,1,4,5,8,9,10,15,25};

            array = Sorts.GnomSort(array);
            
            Assert.AreEqual(array,expectedArray);
        }
        
        
    }
}