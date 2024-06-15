// F(n) = F(n - 1) + F(n - 2), for n > 1.

// Example 2:

// Input: n = 3
// Output: 2
// Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.
Dictionary<int, int> mem = new Dictionary<int, int>();
var r = Fib(4, mem);
var r1 = FibDP(4);
Console.ReadLine();

int FibDP(int n)
{
    if (n < 2) return n;
    var dp = new int[n + 1];
    dp[0] = 1;
    dp[1] = 1;
    for (var i = 2; i < n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2];
    }

    return dp[n - 1];
}

int Fib(int n, Dictionary<int, int> mem)
{
    if (n < 2) return n;
    if (!mem.ContainsKey(n))
    {
        mem.Add(n, Fib(n - 1, mem) + Fib(n - 2, mem));
    }
    return mem[n];
}
