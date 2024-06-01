internal class Program
{
    private static void Main(string[] args)
    {
        // III
        // LVIII
        // MCMXCIV
        int arabNumb = RomanToInt("III");
        Console.ReadLine();
    }

    private static int RomanToInt(string s)
    {
        var romanNumsMap = new Dictionary<string, int>(){
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
        if(s.Length == 1) return romanNumsMap[s];
       
        var arabNum = 0;
        int i = 0;
        while (i < s.Length)
        {
            string num2Symb = "";
            if (i + 1 < s.Length)
            {
                num2Symb = new string(new Char[] { s[i], s[i + 1] });

            }
            if (romanNumsMap.ContainsKey(num2Symb))
            {
                arabNum = arabNum + romanNumsMap[num2Symb];
                i += 2;
            }
            else if (romanNumsMap.ContainsKey(new string(new Char[] { s[i] })))
            {
                arabNum = arabNum + romanNumsMap[new string(new Char[] { s[i] })];
                i++;
            }
        }
        return arabNum;
    }
}