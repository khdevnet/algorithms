internal class Program
{
    private static void Main(string[] args)
    {
        // Input: haystack = "sadbutsad", needle = "sad"
        // Output: 0
        // var haystack = "sadbutsad";
        // var needle = "sad";

        var haystack = "mississippi";
        var needle = "issipi";
        var indx = StrStr(haystack, needle);
        Console.ReadLine();
    }

    private static int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length) return -1;
        int n = 0;
        int m = 0;
        int start = n;
        while (n < haystack.Length)
        {
            if (n + needle.Length - 1 > haystack.Length - 1) { return -1; }

            start = n;
            while (m < needle.Length)
            {
                if (haystack[n] != needle[m])
                {
                    n = start;
                    m = 0;
                    break;
                }
                else
                {
                    n++;
                    m++;
                }
            }
            n++;

            if (m == needle.Length) return start;
        }

        return -1;
    }
}