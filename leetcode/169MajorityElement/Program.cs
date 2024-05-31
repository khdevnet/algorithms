internal class Program
{
    private static void Main(string[] args)
    {
        var nums = new []{2,2,1,1,1,2,2,3,3};
        var maj = MajorityElement(nums);
        Console.WriteLine(maj);
        Console.ReadLine();
    }

    private static int MajorityElement(int[] nums) {
        if(nums.Length<=2) return nums[0];

        int majCount = nums.Length/2;
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.TryAdd(num, 1);
            }
            else
            {
                dict[num] = ++dict[num];
            }
        }
        var majKey=0;
        var maxCount=0;
        foreach (var pair in dict)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                majKey = pair.Key;
            }
        }
        return majKey;
    }
}