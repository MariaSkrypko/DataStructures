using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BinaryTree
    {
        public class Node
        {
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int value)
            {
                Value = value;
                Left = Right = null;
            }
        }

        public Node Root;
        public int Count;

        public BinaryTree()
        {
            Root = null;
            Count = 0;
        }

        public void Add(int value)
        {
            Root = AddRecursive(Root, value);
            Count++;
        }

        private Node AddRecursive(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        public bool Contains(int value)
        {
            return ContainsRecursive(Root, value);
        }

        private bool ContainsRecursive(Node node, int value)
        {
            if (node == null)
                return false;

            if (value == node.Value)
                return true;

            return value < node.Value
                ? ContainsRecursive(node.Left, value)
                : ContainsRecursive(node.Right, value);
        }

        public void Clear()
        {
            Root = null;
            Count = 0;
        }

        public object[] ToArray()
        {
            var result = new List<object>();
            InOrderTraversal(Root, result);
            return result.ToArray();
        }

        private void InOrderTraversal(Node node, List<object> result)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Value);
                InOrderTraversal(node.Right, result);
            }
        }
    }
}

