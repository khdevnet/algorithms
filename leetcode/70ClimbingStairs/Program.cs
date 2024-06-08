internal class Program
{
    private static void Main(string[] args)
    {
        var c = ClimbStairs(3);
        var c2 = Climb_Stairs_BottomUp(3);
        Console.ReadLine();
    }

    private static int ClimbStairs(int n)
    {
        var mem = new Dictionary<int, int>();
        return Climb_Stairs(0, n, mem);
    }

    // Complexity 2^n
    // using memoize O(n)
    private static int Climb_Stairs(int stair, int lastStair, Dictionary<int, int> mem)
    {
        if (mem.ContainsKey(stair)) return mem[stair];
        if (stair > lastStair) return 0;
        if (stair == lastStair) return 1;

        var count = Climb_Stairs(stair + 1, lastStair, mem) + Climb_Stairs(stair + 2, lastStair, mem);
        mem[stair] = count;
        return count;
    }

    // dynamic programming, bottom up approach
    // ith variations= (ith-1)+(ith-2)
    // n=3  3 = (3-1)+ (3-2)
    private static int Climb_Stairs_BottomUp(int n)
    {
        if (n == 1) return 1;
        int[] count = new int[n + 1];
        count[1] = 1;
        count[2] = 2;
        for (int i = 3; i <= n; i++)
        {
            count[i] = count[i - 1] + count[i - 2];
        }
        return count[n];
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