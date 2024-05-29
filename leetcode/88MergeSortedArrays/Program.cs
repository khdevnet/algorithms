var sol = new Solution();
//int m = 3;
//int n = 3;
// int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
// int[] nums2 = new int[] { 2, 5, 6 };
// [1,2,3,0,0,0]
// [2,5,6]

//int m = 3;
//int n = 3;
//int[] nums1 = new int[] {4,5,6,0,0,0 };
// int[] nums2 = new int[] { 1,2,3 };
// [4,5,6,0,0,0]
// [1,2,3]

// [0,0,0,0,0]
// [1,2,3,4,5]

int m = 0;
int n = 5;
int[] nums1 = new int[] { 0, 0, 0, 0, 0 };
int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
sol.Merge(nums1, m, nums2, n);
Console.ReadLine();
