using ArraysQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayQuestionsUnitTests
{
    [TestClass]
    public class Task06SearchInsertPositionTest
    {
        [TestMethod]
        public void Test()
        {
            var result1 = Task06SearchInsertPosition.Do(new int[] { 1, 3, 5, 6 }, 5);
            var result2 = Task06SearchInsertPosition.Do(new int[] { 1, 3, 5, 6 }, 2);
            var result3 = Task06SearchInsertPosition.Do(new int[] { 1, 3, 5, 6 }, 7);
            var result4 = Task06SearchInsertPosition.Do(new int[] { 1, 3, 5, 6 }, 0);
            var result5 = Task06SearchInsertPosition.Do(new int[] { 1 }, 1);

            Assert.IsTrue(result1 == 2);
            Assert.IsTrue(result2 == 1);
            Assert.IsTrue(result3 == 4);
            Assert.IsTrue(result4 == 0);
            Assert.IsTrue(result5 == 0);
        }
    }
}
