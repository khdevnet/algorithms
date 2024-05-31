internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 1, 2, 1, 3, 2, 5 };
        var singleNums = SingleNumber(nums);
        Console.ReadLine();
    }

    private static int[] SingleNumber(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num] = ++dict[num];
            }
            else
            {
                dict.Add(num, 1);
            }
        }

        var res = new int[2];
        var i = 0;
        foreach (var pair in dict)
        {
            if (pair.Value == 1) { res[i] = pair.Key; i++; }
        }
        return res;
    }
}