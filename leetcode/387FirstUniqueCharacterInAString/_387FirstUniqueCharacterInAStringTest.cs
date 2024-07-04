namespace _387FirstUniqueCharacterInAString
{
    public class _387FirstUniqueCharacterInAStringTest
    {
        private Solution _solution;

        public _387FirstUniqueCharacterInAStringTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("loveleetcode", 2)]
        public void Test(string str, int expectedIndx)
        {
            Assert.Equal(expectedIndx, _solution.FirstUniqChar(str));
        }

        public class Solution
        {
            public int FirstUniqChar(string s)
            {
                var mem = new Dictionary<char, int[] >();
                for (var i = 0; i < s.Length; i++)
                {
                    if (mem.ContainsKey(s[i]))
                    {
                        mem[s[i]][1]++;
                    }
                    else
                    {
                        mem.Add(s[i], new int[2] { i, 1 });
                    }
                }

                foreach (var l in s)
                {
                    if (mem[l][1] == 1) return mem[l][0];
                }
                return -1;
            }
        }
    }
}