var s = "Let's take LeetCode contest";
var r = ReverseWords(s);

Console.ReadLine();

string ReverseWords(string s)
{
    if (string.IsNullOrEmpty(s)) return s;

    int start = 0;
    int end = 0;
    var newStr = "";
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ' || i == s.Length - 1)
        {
            start = end;
            end = i + 1;
            for (var i1 = end - 2; i1 >= start; i1--)
            {
                newStr = newStr + s[i1];
            }
            if (i != s.Length - 1) newStr = newStr + ' ';
        }
    }
    return newStr;
}

string ReverseWord(string s)
{
    if (string.IsNullOrEmpty(s)) return "";

    return ReverseWord(s.Substring(1)) + s[0];
}


// Example 1:

// Input: s = "Let's take LeetCode contest"
// Output: "s'teL ekat edoCteeL tsetnoc"
// Example 2:

// Input: s = "Mr Ding"
// Output: "rM gniD"
