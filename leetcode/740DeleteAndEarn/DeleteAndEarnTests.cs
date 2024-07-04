using Xunit.Abstractions;

namespace _740DeleteAndEarn;

public class DeleteAndEarnTests
{
    private readonly Solution solution;

    public DeleteAndEarnTests()
    {
        solution = new Solution();
    }

    [Fact]
    public void Test()
    {
        var nums = new int[] { 2, 2, 3, 3, 3, 4 };
        var earn = solution.DeleteAndEarn(nums);
    }

    // You are given an integer array nums. You want to maximize the number of points you get by performing the following operation any number of times:

    // Pick any nums[i] and delete it to earn nums[i] points. Afterwards, you must delete every element equal to nums[i] - 1 and every element equal to nums[i] + 1.
    // Return the maximum number of points you can earn by applying the above operation some number of times.
    // Example 1:

    // Input: nums = [3,4,2]
    // Output: 6
    // Explanation: You can perform the following operations:
    // - Delete 4 to earn 4 points. Consequently, 3 is also deleted. nums = [2].
    // - Delete 2 to earn 2 points. nums = [].
    // You earn a total of 6 points.
    // Example 2:

    // Input: nums = [2,2,3,3,3,4]
    // Output: 9
    // Explanation: You can perform the following operations:
    // - Delete a 3 to earn 3 points. All 2's and 4's are also deleted. nums = [3,3].
    // - Delete a 3 again to earn 3 points. nums = [3].
    // - Delete a 3 once more to earn 3 points. nums = [].
    // You earn a total of 9 points.
    public class Solution
    {
        //  n   n+1
        // [2,   2,    3,   3,  3,  4]
        //

        public int DeleteAndEarn(int[] nums)
        {
            if (nums.Length == 0) return 0;
            var newNum = nums.ToList();
            var buf = new List<int>();
            var i = 0;
            var delIndx = 0;
            var sum = 0;
            while (i < newNum.Count)
            {
                if (i == delIndx)
                {
                    sum += newNum[delIndx];
                    i++;
                    continue;
                }
                else if (i <= newNum.Count - 1 && (newNum[i] == newNum[delIndx] - 1 || newNum[i] == newNum[delIndx] + 1))
                {
                    i++;
                    continue;
                }

                if (i == newNum.Count - 1)
                {
                    newNum = buf;
                    i = 0;
                    continue;
                }
                buf.Add(newNum[i]);
                i++;
            }

            return sum;
        }
    }
}

