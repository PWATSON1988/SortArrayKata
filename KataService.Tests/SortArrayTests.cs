using Xunit;
using Kata.SortArray;

namespace Katas.SortArray
{
    public class SortArrayTests
    {
        private readonly SortArrayKata _sortArrayKata;

        public SortArrayTests()
        {
            _sortArrayKata = new SortArrayKata();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //If there are any extra tests you would like to add to further validate your solution, please do so here
        //Insert test code here (optional...)
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        [Fact]
        public void SortArrayBasicTest()
        {
            Assert.Equal(new int[] { 1, 3, 2, 8, 5, 4 }, _sortArrayKata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        [Fact]
        public void SortArrayBasicTest2()
        {
            Assert.Equal(new int[] { 1, 3, 5, 8, 0 }, _sortArrayKata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        }

        [Fact]
        public void SortArrayBasicTest3()
        {
            Assert.Equal(new int[] { 0, 0, 0, 3, 6, 5 }, _sortArrayKata.SortArray(new int[] { 0, 0, 0, 5, 6, 3 }));
        }

        [Fact]
        public void SortArrayBasicTest4()
        {
            Assert.Equal(new int[] { 1, 1, 3, 3, 6, 5 }, _sortArrayKata.SortArray(new int[] { 1, 1, 5, 3, 6, 3 }));
        }

        [Fact]
        public void SortArrayBasicTest5()
        {
            Assert.Equal(new int[] { 6, 1, 8, 1, 2, 3, 4, 3, 6, 3, 2, 3, 0, 9 }, _sortArrayKata.SortArray(new int[] { 6, 3, 8, 9, 2, 3, 4, 3, 6, 1, 2, 3, 0, 1 }));
        }

        [Fact]
        public void SortArrayBasicTest6()
        {
            Assert.Equal(new int[] { 0, 0, 7, 9 }, _sortArrayKata.SortArray(new int[] { 0, 0, 9, 7 }));
        }

        [Fact]
        public void SortArrayBasicTest7()
        {
            Assert.Equal(new int[] { 2, 7, 8, 9 }, _sortArrayKata.SortArray(new int[] { 2, 9, 8, 7 }));
        }

        [Fact]
        public void SortArrayBasicTest8()
        {
            Assert.Equal(new int[] { 2, 3, 5, 8, 2, 4, 7, 8 }, _sortArrayKata.SortArray(new int[] { 2, 7, 3, 8, 2, 4, 5, 8}));
        }
        
        [Fact]
        public void SortArrayTestWithNull()
        {
            Assert.Equal(new int[] { }, _sortArrayKata.SortArray(new int[] { }));
        }
    }
}