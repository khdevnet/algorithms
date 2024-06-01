internal class Program
{
    private static void Main(string[] args)
    {
        // III
        // LVIII
        // MCMXCIV
        int arabNumb = RomanToInt("MCMXCIV");
        Console.ReadLine();
    }

    private static Dictionary<string, int> romanNumsMap = new Dictionary<string, int>(){
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

    private static int RomanToInt(string s)
    {
        if (s.Length == 1) return romanNumsMap[s];
        var calculatedIndx = new HashSet<int>();
        var arabNum = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            var numSymb = new string(new Char[] { s[i], s[i + 1] });
            if (romanNumsMap.ContainsKey(numSymb))
            {
                arabNum = arabNum + romanNumsMap[numSymb];
                calculatedIndx.Add(i);
                calculatedIndx.Add(i + 1);
            }
        }

        for (int j = 0; j < s.Length; j++)
        {
            var numSymb1 = new string(new Char[] { s[j] });
            if (!calculatedIndx.Contains(j))
            {
                arabNum = arabNum + romanNumsMap[numSymb1];
            }
        }
        return arabNum;
    }

    public int RomanToIntV2(string s)
    {
        int sum = 0;
        int i = 0;
        while (i < s.Length)
        {
            if (i < s.Length - 1)
            {
                string doubleSymbol = s.Substring(i, 2);
                if (romanNumsMap.ContainsKey(doubleSymbol))
                {
                    sum += romanNumsMap[doubleSymbol];
                    i += 2;
                    continue;
                }
            }

            string singleSymbol = s.Substring(i, 1);
            sum += romanNumsMap[singleSymbol];
            i += 1;
        }

        return sum;
    }
}