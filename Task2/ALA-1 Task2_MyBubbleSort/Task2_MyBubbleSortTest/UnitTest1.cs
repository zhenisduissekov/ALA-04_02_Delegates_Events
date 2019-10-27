using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task2_MyBubbleSort.Program;

namespace Task2_MyBubbleSortTest
{
    [TestClass]
    public class UnitTest1
    {
        delegate int SortA(int[] a);

        [TestMethod]
        public void TestMethod1_sorting_with_and_without_calling_delegate()
        {
            // arrange
            int[] test_array = { 101, -1, 0, 53, 3, -23, 111, 5934, 33 };
            int[] test1_array = { 101, -1, 0, 53, 3, -23, 111, 5934, 33 };
            // act
            Bubble_Sort BS;
            BS = Bubble_Sort_Ascending;
            Bubble_Sort_Ascending(ref test_array);
            BS(ref test1_array);
            // assert

            CollectionAssert.AreEqual(test_array, test1_array);
           
        }

        [TestMethod]
        public void TestMethod2_check_for_max()
        {
            // arrange
            int[] a = { 101, -1, 0, 53, 3, -23, 111, 5934, 33 };
            int a_max = 5934;
            // act
            ArrayMan arrayMan;
            arrayMan = SortArrayMaxs;
            // arrayMan(jagged_arr);
            SortA sortA;
            sortA = FindMaxmInArray;
            // assert
            Assert.AreEqual(a_max, sortA(a));

        }
    }
}
