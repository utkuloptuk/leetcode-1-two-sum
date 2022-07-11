using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_1_two_sum
{
    [TestClass]
    public class SolutionTest
    {
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 })]
        [DataRow(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
        [TestMethod]
        public void NumberList_Compare_Target_After_Return_Succeed(int[] numbs, int target, int[] excepted_result)
        {
            var result = Solution.TwoSum(numbs, target);
            Assert.IsTrue(result.SequenceEqual(excepted_result));
        }
    }
}
