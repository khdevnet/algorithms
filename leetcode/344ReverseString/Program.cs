var l = new char[] { 'h', 'e', 'l', 'l', 'o' };
var l2 = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
ReverseString(l2);
Console.ReadLine();

static void ReverseString(char[] s)
{
    R(s, 0, s.Length - 1);
}

static void R(char[] s, int i, int j)
{
    if (i >= j) return;
    var b = s[i];
    s[i] = s[j];
    s[j] = b;
    R(s, i + 1, j - 1);
}
