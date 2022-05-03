using System;

namespace MmGuideAssignment
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public BinaryTree() { root = null; }

        void printResult() { GetParentHavingOneLeafPostorder(root); }

        public void GetParentHavingOneLeafPostorder(Node node)
        {
            if (node == null)
                return;

            GetParentHavingOneLeafPostorder(node.left);

            GetParentHavingOneLeafPostorder(node.right);

            if (ParentHavingOneLeaf(node))
            {
                Console.WriteLine(node.key);
            }
        }

        public bool HasOneChild(Node node)
        {
            if (!IsLeaf(node) && (node.left == null || node.right == null))
            {
                return true;
            }
            return false;
        }

        public bool IsLeaf(Node node)
        {
            if (node.left == null && node.right == null)
            {
                return true;
            }
            return false;
        }

        private bool ParentHavingOneLeaf(Node node)
        {
            if (HasOneChild(node))
            { 
                Node child = node.left == null? node.right : node.left;
                if (IsLeaf(child))
                {
                    return true;
                }
            }
            return false;
        }

        static public void TestTree()
        {
            BinaryTree tree = GetBTree();
            tree.printResult();
        }

        private static BinaryTree GetBTree()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(50);

            tree.root.left = new Node(17);
            tree.root.right = new Node(76);

            tree.root.left.left = new Node(9);
            tree.root.left.right = new Node(23);

            tree.root.right.left = new Node(54);

            tree.root.left.left.right = new Node(14);
            tree.root.left.right.left = new Node(19);

            tree.root.right.left.right = new Node(72);

            tree.root.left.left.right.left = new Node(12);
            tree.root.right.left.right.left = new Node(67);
            
            return tree;
        }
    }
}
