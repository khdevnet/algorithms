internal class Program
{
    private static void Main(string[] args)
    {
        // int[] nums = { 2, 7, 11, 15 };
        // int target = 9;

        int[] nums = { 3, 2, 3 };
        int target = 6;
        var indexes = TwoSum(nums, target);
        Console.WriteLine(indexes);
        Console.ReadLine();
    }

    private static int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 1) return new int[0];
        if (nums.Length == 2) return new[] { 0, 1 };
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var arg1 = target - nums[i];
            if (map.ContainsKey(arg1))
            {
                return new int[] { map[arg1], i };
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }
}