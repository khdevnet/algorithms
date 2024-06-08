internal class Program
{
    private static void Main(string[] args)
    {
        var c = ClimbStairs(3);
        Console.ReadLine();
    }

    private static int ClimbStairs(int n)
    {
        return Climb_Stairs(0, n);
    }

    private static int Climb_Stairs(int i, int n)
    {
        if (i > n)
        {
            return 0;
        }

        if (i == n)
        {
            return 1;
        }

        return Climb_Stairs(i + 1, n) + Climb_Stairs(i + 2, n);
    }

    // Example 1:

    // Input: n = 2
    // Output: 2
    // Explanation: There are two ways to climb to the top.
    // 1. 1 step + 1 step
    // 2. 2 steps
    // Example 2:

    // Input: n = 3
    // Output: 3
    // Explanation: There are three ways to climb to the top.
    // 1. 1 step + 1 step + 1 step
    // 2. 1 step + 2 steps
    // 3. 2 steps + 1 step

    // Input: n = 4
    // Output: 3
    // Explanation: There are three ways to climb to the top.
    // 1. 1 step + 1 step + 1 step + 1 step
    // 2. 1 step + 1 step + 2 steps
    // 3. 1 step + 2 step + 1 steps
    // 4. 2 steps + 1 step + 1 step
    // 5. 2 steps + 2 step
}