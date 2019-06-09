using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        private TreeNode Root;

        private int maxDepth = 0;

        private List<int> nodes;
        

        public BinaryTree(TreeNode root)
        {
            Root = root;
        }

        public List<int> IterativePreOrderTraversal()
        {
            nodes = new List<int>();

            if (Root != null)
            {
                Stack<TreeNode> nodeStack = new Stack<TreeNode>();

                nodeStack.Push(Root);

                while (nodeStack.Count > 0)
                {
                    TreeNode node = nodeStack.Peek();
                    nodes.Add(node.Val);
                    nodeStack.Pop();

                    if (node.Right != null)
                    {
                        nodeStack.Push(node.Right);
                    }

                    if (node.Left != null)
                    {
                        nodeStack.Push(node.Left);
                    }
                }
            }

            return nodes;
        }

        public List<int> IterativeInOrderTraversal()
        {
            nodes = new List<int>();

            if (Root != null)
            {
                Stack<TreeNode> nodeStack = new Stack<TreeNode>();

                TreeNode node = Root;

              
                while ((node != null) || (nodeStack.Count > 0))
                {
                    while(node != null)
                    {
                        nodeStack.Push(node);
                        node = node.Left;
                    }

                    node = nodeStack.Peek();
                    nodes.Add(node.Val);
                    nodeStack.Pop();

                    node = node.Right;
                }
            }

            return nodes;
        }

        public List<int> IterativePostOrderTraversal()
        {
            nodes = new List<int>();

            if (Root != null)
            {
                Stack<TreeNode> nodeStack1 = new Stack<TreeNode>();
                Stack<TreeNode> nodeStack2 = new Stack<TreeNode>();

                nodeStack1.Push(Root);

                while (nodeStack1.Count > 0)
                {
                    TreeNode node = nodeStack1.Peek();
                    nodeStack2.Push(node);
                    nodeStack1.Pop();

                    if (node.Left != null)
                    {
                        nodeStack1.Push(node.Left);
                    }

                    if (node.Right != null)
                    {
                        nodeStack1.Push(node.Right);
                    }
                }

                while(nodeStack2.Count > 0)
                {
                    nodes.Add(nodeStack2.Pop().Val);
                }
            }

            return nodes;
        }

        public List<List<int>> IterativeLevelOrderTraversal()
        {
            List<List<int>> levels = new List<List<int>>();

            if(Root != null)
            {
                Queue<TreeNode> nodeQueue = new Queue<TreeNode>();

                nodeQueue.Enqueue(Root);

                while(nodeQueue.Count > 0)
                {
                    int count = nodeQueue.Count;
                    List<int> nodes = new List<int>();

                    while (count > 0)
                    {
                        TreeNode node = nodeQueue.Peek();
                        nodes.Add(node.Val);
                        nodeQueue.Dequeue();

                        if(node.Left != null)
                        {
                            nodeQueue.Enqueue(node.Left);
                        }

                        if(node.Right != null)
                        {
                            nodeQueue.Enqueue(node.Right);
                        }

                        count--;
                    }

                    levels.Add(nodes);
                }
            }

            return levels;
        }

        public int MaxDepth()
        {
            FindMaxDepth(Root, 1);

            return maxDepth;
        }

        private void FindMaxDepth(TreeNode root, int depth) 
        {
           if(root == null)
           {
                return;
           }

           if((root.Left == null) && (root.Right == null))
           {
                maxDepth = Math.Max(maxDepth, depth);
           }

            FindMaxDepth(root.Left, depth + 1);
            FindMaxDepth(root.Right, depth + 1);

        }

        public List<int> RecursivePreOrderTraversal()
        {
            nodes = new List<int>();
            PreOrder(Root);
            return nodes;
        }

        private void PreOrder(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            nodes.Add(root.Val);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        public List<int> RecursiveInOrderTraversal()
        {
            nodes = new List<int>();
            InOrder(Root);
            return nodes;
        }

        private void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.Left);
            nodes.Add(root.Val);
            InOrder(root.Right);
        }

        public List<int> RecursivePostOrderTraversal()
        {
            nodes = new List<int>();
            PostOrder(Root);
            return nodes;
        }

        private void PostOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.Left);
            PostOrder(root.Right);
            nodes.Add(root.Val);
        }
    }
}
