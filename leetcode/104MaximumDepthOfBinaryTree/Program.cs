// Input: root = [3,9,20,null,null,15,7]
// Output: 3
//      3
//    9  20
//      15  17 

var root =
new TreeNode(
    3,
    left: new TreeNode(9),
    right: new TreeNode(
        20,
        left: new TreeNode(15),
        right: new TreeNode(17))
 );

var d = MaxDepth(root);

Console.ReadLine();

int MaxDepthLC(TreeNode root)
{
    if (root == null)
    {
        return 0;
    }

    var rL = MaxDepth(root.right);
    var lL = MaxDepth(root.left);
    return 1 + Math.Max(rL, lL);
}

int MaxDepth(TreeNode root)
{
    return root == null ? 0 : CalDepth(root) + 1;
}
int CalDepth(TreeNode root)
{
    if (root == null) return 0;
    var rightDepthCount = root.right == null ? 0 : CalDepth(root.right) + 1;
    var leftDepthCount = root.left == null ? 0 : CalDepth(root.left) + 1;
    var depthCount = rightDepthCount > leftDepthCount
    ? rightDepthCount
    : leftDepthCount;
    return depthCount;
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