// var root = new int[] { 4, 2, 7, 1, 3 };
// [4,2,7,1,3]
// [18,2,22,null,null,null,63,null,84,null,null]
// var val = 2;

var root = new TreeNode(
    4,
    left: new TreeNode(2,
                       left: new TreeNode(1),
                       right: new TreeNode(3)
    ),
    right: new TreeNode(7));

var node = SearchBST(root, 5);
Console.ReadLine();

TreeNode SearchBST(TreeNode root, int val)
{
    if (root == null) return root;
    if (root.val == val) return root;

    // Binary search tree has structure
    // where number in the left leaf < then root.val
    // number in the right leaf > then root.val
    return root.val < val
    ? SearchBST(root.right, val)
    : SearchBST(root.left, val);
}

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
