namespace _136SingleNumber;

public class _136SingleNumberTest
{
    private Solution _solution;

    public _136SingleNumberTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    public void Test(int[] nums, int expected)
    {
        Assert.Equal(expected, _solution.SingleNumber(nums));
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var mem = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (mem.ContainsKey(nums[i]))
                {
                    mem[nums[i]]++;
                }
                else
                {
                    mem.Add(nums[i], 1);
                }
            }

            foreach (var it in mem)
            {
                if (it.Value == 1) return it.Key;
            }
            return -1;
        }
    }
}