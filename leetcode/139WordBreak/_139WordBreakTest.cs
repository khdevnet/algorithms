using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;

namespace _139WordBreak;
//Example 1:

//Input: s = "leetcode", wordDict = ["leet","code"]
//Output: true
//Explanation: Return true because "leetcode" can be segmented as "leet code".
//Example 2:

//Input: s = "applepenapple", wordDict = ["apple","pen"]
//Output: true
//Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
//Note that you are allowed to reuse a dictionary word.
//Example 3:

//Input: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
//Output: false
public class _139WordBreakTest
{
    private readonly Solution _solution;

    public _139WordBreakTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("leetcode", new string[] { "leet", "code" }, true)]
    [InlineData("applepenapple", new string[] { "apple", "pen" }, true)]
    [InlineData("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" }, false)]
    public void Test1(string phrase, string[] words, bool expected)
    {
        Assert.Equal(expected, _solution.WordBreak(phrase, words));
    }

    public class Solution
    {
        // basecases
        // s is null or empty
        // recurrence reference
        // f(s, word) = f(s - word[i], word[i]) && f(s - word[i+1], word[i+1]) 
        // use all words from wordDict starts from any first word
        public bool WordBreak(string s, IList<string> wordDict)
        {
            return WordBreak(s, wordDict, 0);
        }

        public bool WordBreak(string s, IList<string> wordDict, int indx)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (indx > wordDict.Count - 1) return true;

            var startIndex = s.IndexOf(wordDict[indx]);
            if (startIndex >= 0)
            {
                var newStr = s.Remove(startIndex, wordDict[indx].Length);
                return true && WordBreak(newStr, wordDict, ++indx);
            }
            return false;
        }
    }
}