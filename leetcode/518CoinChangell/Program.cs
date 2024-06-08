internal class Program
{
    private static void Main(string[] args)
    {
        var r = Change(5, new int[] { 1, 2, 5 });
        Console.ReadLine();
    }
    private static int Change(int amount, int[] coins)
    {
        return CalcChange(0, amount, coins);
    }

    private static int CalcChange(int step, int amount, int[] coins)
    {
        if (step > amount) return 0;
        if (step == amount) return 1;

        return CalcChange(step + coins[0], amount, coins)
        + CalcChange(step + coins[1], amount, coins)
        + CalcChange(step + coins[2], amount, coins);
    }
}

// Example 1:

// Input: amount = 5, coins = [1,2,5]
// Output: 4
// Explanation: there are four ways to make up the amount:
// 5=5
// 5=2+2+1
// 5=2+1+1+1
// 5=1+1+1+1+1
// Example 2:

// Input: amount = 3, coins = [2]
// Output: 0
// Explanation: the amount of 3 cannot be made up just with coins of 2.
// Example 3:

// Input: amount = 10, coins = [10]
// Output: 1