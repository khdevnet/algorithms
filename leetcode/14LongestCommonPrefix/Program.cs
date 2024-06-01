internal class Program
{
    private static void Main(string[] args)
    {
        // var strs = new string[] { "flower", "flow", "flight" };
        var strs = new string[] { "ab", "a" };
        var prefix = LongestCommonPrefix(strs);
        Console.ReadLine();
    }

    private static string LongestCommonPrefix(string[] strs)
    {
        int longestWordLength = 0;
        string longestWord = "";
        foreach (var word in strs)
        {
            if (word.Length > longestWordLength)
            {
                longestWordLength = word.Length;
                longestWord = word;
            }
        }
        var prefix = longestWord;
        for (int i = 0; i < longestWordLength; i++)
        {
            int count = 0;
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j].StartsWith(prefix))
                {
                    count++;
                }
            }
            if (strs.Length == count)
            {
                return prefix;
            }
            else
            {
                count = 0;
                prefix = longestWord.Substring(0, longestWordLength - (i + 1));
            }
        }

        return "";
    }

    private static string LongestCommonPrefixV2(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                    return "";
            }

        return prefix;
    }
}