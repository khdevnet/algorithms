var s = "Let's take LeetCode contest";
var r = ReverseWords(s);

Console.ReadLine();

string ReverseWords(string s)
{
    if (string.IsNullOrEmpty(s)) return s;
    var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = ReverseWord(words[i]);
    }
    return string.Join(" ", words);
}

string ReverseWord(string s)
{
    if (string.IsNullOrEmpty(s)) return s;
    return ReverseWord(s.Substring(1)) + s[0];
}


// Example 1:

// Input: s = "Let's take LeetCode contest"
// Output: "s'teL ekat edoCteeL tsetnoc"
// Example 2:

// Input: s = "Mr Ding"
// Output: "rM gniD"
