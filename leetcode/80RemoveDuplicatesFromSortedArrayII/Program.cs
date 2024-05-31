internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        // int[] nums = { 1,2,2 };
        // int[] nums ={1, 2, 2, 3};
        RemoveDuplicates(nums);
        Console.ReadLine();
    }

    // Algorithm
    // We define two pointers, i and j for our algorithm. The pointer i iterates of the array processing one element at a time and j keeps track of the next location in the array where we can overwrite an element.
    // We also keep a variable count which keeps track of the count of a particular element in the array. Note that the minimum count would always be 1.
    // We start with index 1 and process one element at a time in the array.
    // If we find that the current element is the same as the previous element i.e. nums[i] == nums[i - 1], then we increment the count. If the value of count > 2, then we have encountered an unwanted duplicate element. In this case, we simply move forward i.e. we increment i but not j.
    // However, if the count is <= 2, then we can move the element from index i to index j.
    static int RemoveDuplicates(int[] nums)
    {
         // Initialize the counter and the second pointer.
        int j = 1, count = 1;
        // Start from the second element of the array and process
        // elements one by one.
        for (int i = 1; i < nums.Length; i++) {
            // If the current element is a duplicate, increment the count.
            if (nums[i - 1] == nums[i]) {
                count++;
            } else {
                // Reset the count since we encountered a different element
                // than the previous one.
                count = 1;
            }

            // For a count <= 2, we copy the element over thus
            // overwriting the element at index "j" in the array
            if (count <= 2) {
                nums[j++] = nums[i];
            }
        }

        return j;
    }
}

//Example 1:

//Input: nums = [1, 1, 1, 2, 2, 3]
//Output: 5, nums = [1, 1, 2, 2, 3, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).

//  ?  ?!
// [1, 1, 1, 2, 2, 3] 
//     ?  !?
// [1, 1, 1, 2, 2, 3] 
//     ?  !  ?
// [1, 1, 1, 2, 2, 3] 
