internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    //definition for a binary tree node.
    public class treenode
    {
        public int val;
        public treenode left;
        public treenode right;
        public treenode(int val = 0, treenode left = null, treenode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    public IList<int> InorderTraversal(treenode root)
    {

        List<int> list = new List<int>();
        inorder(root, list);

        return list;
    }
    public void inorder(treenode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }
        inorder(node.left, list);
        list.Add(node.val);
        inorder(node.right, list);

    }
}
