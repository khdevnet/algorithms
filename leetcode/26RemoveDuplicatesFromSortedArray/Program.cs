internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        // int[] nums = { 1, 2, 3 };
        // int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int[] nums = { 1, 1, 2 };
        RemoveDuplicates(nums);
        Console.ReadLine();
    }

    static int RemoveDuplicates(int[] nums)
    {
        var uniqueItemPos = 0;
        var nextUniqueItemPos = 0;
        while (nextUniqueItemPos < nums.Length)
        {
            if (nums[uniqueItemPos] != nums[nextUniqueItemPos])
            {
                nums[++uniqueItemPos] = nums[nextUniqueItemPos];
            }
            nextUniqueItemPos++;
        }

        return uniqueItemPos + 1;
    }
}

// Input: nums = [1,1,2]
// Output: 2, nums = [1, 2, _]
// Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
// It does not matter what you leave beyond the returned k (hence they are underscores).

// Test case 2
// [0,0,1,1,1,2,2,3,3,4]

// Test case 3
// [1,2,3]