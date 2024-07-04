namespace _125ValidPalindrome;

public class _125ValidPalindromeTest
{
    private Solution _solution;

    public _125ValidPalindromeTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("0P", false)]
    public void Test(string input, bool expected)
    {
        Assert.Equal(expected, _solution.IsPalindrome(input));
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (s.Length == 1) return true;
            var start = 0;
            var end = s.Length - 1;
            while (start <= end)
            {
                var startChar = Char.ToLower(s[start]);
                var endChar = Char.ToLower(s[end]);
                if (startChar == ' ' || !Char.IsLetterOrDigit(startChar))
                {
                    start++;
                    continue;
                }
                if (endChar == ' ' || !Char.IsLetterOrDigit(endChar))
                {
                    end--;
                    continue;
                }
                if (startChar != endChar) { return false; }
                else { start++; end--; }
            }
            return true;
        }
    }
}