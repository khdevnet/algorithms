internal class Program
{
    private static void Main(string[] args)
    {
        // var s = "()[]{}";
        var s = "){";
        var output = IsValid(s);
        Console.ReadLine();
    }

    private static readonly Dictionary<char, char> openClosedBracketsMap
    = new()
    {
        {'(',')'},
        {'[',']'},
        {'{','}'}
    };


    private static bool IsValid(string s)
    {
        if (s.Length == 0) return true;
        if (s.Length % 2 != 0) return false;

        var nextClosedBrackets = new Stack<char>();
        foreach (var bracket in s)
        {
            if (openClosedBracketsMap.ContainsKey(bracket))
            {
                nextClosedBrackets.Push(openClosedBracketsMap[bracket]);
            }
            else
            {
                if(nextClosedBrackets.Count == 0) return false;
                var closedBracket = nextClosedBrackets.Pop();
                if (closedBracket != bracket) return false;
            }
        }
        return nextClosedBrackets.Count == 0;
    }
}