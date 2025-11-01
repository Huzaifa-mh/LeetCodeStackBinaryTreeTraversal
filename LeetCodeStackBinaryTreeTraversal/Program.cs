using static Program;

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
    public IList<int> PreorderTraversal(treenode root)
    {
        List<int> list = new List<int>();
        preorder(root, list);

        return list;
    }
    public IList<int> PostorderTraversal(treenode root)
    {
        List<int> list = new List<int>();
        postOrder(root, list);

        return list;
    }
    public void postOrder(treenode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }
        postOrder(node.left, list);
        postOrder(node.right, list);
        list.Add(node.val);
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
    public void preorder(treenode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }

        list.Add(node.val);
        preorder(node.left, list);
        preorder(node.right, list);
    }
}
