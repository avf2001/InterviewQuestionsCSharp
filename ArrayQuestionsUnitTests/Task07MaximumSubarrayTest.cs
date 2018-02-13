using ArraysQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayQuestionsUnitTests
{
    [TestClass]
    public class Task07MaximumSubarrayTest
    {
        [TestMethod]        
        public void Test()
        {
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var result = Task07MaximumSubarray.Do(nums);

            Assert.IsTrue(result == 6);
        }
    }
}
