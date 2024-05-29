using Utils;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 1 && n == 0) return;
        //if (m == 0 && n > 0) { Swap(nums1, nums2, 0, 0); return; }
        if (m == 0) return;
        var i = 0;
        var j = 0;
        var j1 = 0;
        while (i < nums1.Length)
        {
            if (nums1[i] == 0)
            {
                Swap(nums1, nums2, i, j1); i++; j1++;
                // Arrays.Print(nums1);
                continue;
            }

            if (nums1[i] > nums2[j])
            {
                Swap(nums1, nums2, i, j); i++; j++;
               // Arrays.Print(nums1);
            }
            else
            {
                // Arrays.Print(nums1);
                i++;
            }
        }
        // [1,2,3,0,0,0]
        // [2,5,6]

        // [4,5,6,0,0,0]
        // [1,2,3]

    }

    private void Swap(int[] nums1, int[] nums2, int indx, int indx2)
    {
        var b = nums1[indx];
        nums1[indx] = nums2[indx2];
        nums2[indx2] = b;
    }
}