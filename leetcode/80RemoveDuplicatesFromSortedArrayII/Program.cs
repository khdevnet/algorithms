internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        // int[] nums = { 1,2,2 };
        RemoveDuplicates(nums);
        Console.ReadLine();
    }

    static int RemoveDuplicates(int[] nums)
    {
        var uniqueItemPos = 0;
        var nextUniqueItemPos = 0;
        var maxUniqueAppearsCount = 2;
        var uniqueAppearsCounter = 0;
        while (nextUniqueItemPos < nums.Length)
        {
            if (nums[uniqueItemPos] != nums[nextUniqueItemPos])
            {
                nums[++uniqueItemPos] = nums[nextUniqueItemPos];
                uniqueAppearsCounter = 0;
            }
            else if (uniqueAppearsCounter < maxUniqueAppearsCount)
            {
                uniqueAppearsCounter++;
            }
            else if (uniqueAppearsCounter == maxUniqueAppearsCount)
            {
                uniqueAppearsCounter = 0;
                uniqueItemPos = nextUniqueItemPos;

            }
            nextUniqueItemPos++;
        }

        return nextUniqueItemPos;
    }
}

//Example 1:

//Input: nums = [1, 1, 1, 2, 2, 3]
//Output: 5, nums = [1, 1, 2, 2, 3, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).