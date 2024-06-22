namespace _217ContainsDuplicate
{
    public class _217ContainsDuplicateTest
    {
        private Solution _solution;

        public _217ContainsDuplicateTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, true)]
        [InlineData(new int[] { 4, 1 }, false)]
        public void Test(int[] nums, bool expected)
        {
            Assert.Equal(expected, _solution.ContainsDuplicate(nums));
        }

        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
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

                foreach (var val in nums)
                {
                    if (mem[val] >= 2) return true;
                }
                return false;
            }
        }
    }
}