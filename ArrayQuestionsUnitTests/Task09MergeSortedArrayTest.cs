using ArraysQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayQuestionsUnitTests
{
    [TestClass]
    public class Task09MergeSortedArrayTest
    {
        [TestMethod]
        public void Test()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0, 0 };
            var n = 3;
            var nums2 = new int[] { 1, 2, 3, 4};
            var m = 4;
            Task09MergeSortedArray.Do(nums1, 3, nums2, 4);
        }
    }
}
