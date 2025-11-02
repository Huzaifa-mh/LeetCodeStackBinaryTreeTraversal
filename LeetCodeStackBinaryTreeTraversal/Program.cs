using static Program;

internal class Program
{
    private static void Main(string[] args)
    { 
        string result = ClearDigits("ab12"); 
        Console.WriteLine(result);
    }
    //this is not a tree problem.
    //we can improve this code.

    public static string ClearDigits(string s)
    {
        Stack<char> s1 = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0' || s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
            {
                if (s1.Count > 0)
                {
                    s1.Pop();
                }
            }
            else
            {
                s1.Push(s[i]);
            }
        }
        return new string(s1.Reverse().ToArray());
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
    //Inorder: Left-right-root
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
    //Inorder: Left-root-right
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

    //Inorder: root-Left-right
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
