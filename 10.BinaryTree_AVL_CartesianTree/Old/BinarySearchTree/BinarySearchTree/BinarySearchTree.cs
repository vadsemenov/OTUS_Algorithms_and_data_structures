﻿using System;
using System.CodeDom;

namespace BinaryTree
{
    public class BinarySearchTree : IBinarySearchTree
    {
        public Node Root;

        public BinarySearchTree(int rootValue)
        {
            Root = new Node(rootValue, null);
        }

        public void Insert(int x)
        {
            InsertNode(x, Root);
        }

        private Node InsertNode(int x, Node parentNode)
        {
            if (parentNode.Value > x)
            {
                if (parentNode.Left == null)
                {
                    parentNode.Left = new Node(x, parentNode);
                    return parentNode.Left;
                }

                return InsertNode(x, parentNode.Left);
            }

            if (parentNode.Value < x)
            {
                if (parentNode.Right == null)
                {
                    parentNode.Right = new Node(x, parentNode);
                    return parentNode.Right;
                }

                return InsertNode(x, parentNode.Right);
            }

            return parentNode;
        }

        public bool Search(int x)
        {
            try
            {
                SearchNode(x, ref Root);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // private ref Node SearchNode(int x, ref Node parentNode)
        // {
        //     if (parentNode.Value == x)
        //     {
        //         return ref parentNode;
        //     }
        //
        //     if (parentNode.Value > x && parentNode.Left != null)
        //     {
        //         if (parentNode.Left.Value == x)
        //         {
        //             return ref parentNode.Left;
        //         }
        //
        //         return ref SearchNode(x, ref parentNode.Left);
        //     }
        //
        //     if (parentNode.Value < x && parentNode.Right != null)
        //     {
        //         if (parentNode.Right.Value == x)
        //         {
        //             return ref parentNode.Right;
        //         }
        //
        //         return ref SearchNode(x, ref parentNode.Right);
        //     }
        //
        //     throw new ArgumentNullException();
        // }

        private ref Node SearchNode(int x, ref Node parentNode)
        {
            if (parentNode.Value == x)
            {
                return ref parentNode;
            }
        
            ref Node currentNode = ref parentNode;
        
            while (currentNode.Value != x)
            {
                if (currentNode.Value > x && currentNode.Left != null)
                {
                    if (currentNode.Left.Value == x)
                    {
                        return ref currentNode.Left;
                    }
        
                    currentNode = ref currentNode.Left;
                }
                else if (currentNode.Value < x && currentNode.Right != null)
                {
                    if (currentNode.Right.Value == x)
                    {
                        return ref currentNode.Right;
                    }
        
                    currentNode = ref currentNode.Right;
                }
                else if(currentNode.Value == x)
                {
                    return ref currentNode;
                }
            }
        
            throw new ArgumentNullException();
        }

        public void Remove(int x)
        {
            try
            {
                ref var node = ref SearchNode(x, ref Root);

                if (node != null)
                {
                    RemoveNode(ref node);
                }
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        private void RemoveNode(ref Node node)
        {
            if (RemoveNodeIfLeaf(ref node)) return;

            // if all child nodes is not null
            ref var minNodeOfSubtree = ref FindSubtreeMinNode(ref node.Right);

            SwapNodes(ref node, ref minNodeOfSubtree);
        }

        private bool RemoveNodeIfLeaf(ref Node node)
        {
            //If all child nodes are null 
            if (node.Left == null && node.Right == null)
            {
                node = null;
                return true;
            }

            if (node.Left == null) // if one child node is null
            {
                node.Right.ParentNode = node.ParentNode;
                node = node.Right;
                return true;
            }

            if (node.Right == null) // if one child node is null
            {
                node.Left.ParentNode = node.ParentNode;
                node = node.Left;
                return true;
            }

            return false;
        }

        private void SwapNodes(ref Node node, ref Node minNodeOfSubtree)
        {
            node.Value = minNodeOfSubtree.Value;
            RemoveNodeIfLeaf(ref minNodeOfSubtree);
        }

        private ref Node FindSubtreeMinNode(ref Node node)
        {
            ref var minNode = ref node;

            while (minNode.Left != null)
            {
                minNode = minNode.Left;
            }

            return ref minNode;
        }
    }

    public class Node : ICloneable
    {
        public int Value { get; set; }

        public Node ParentNode;
        public Node Left;
        public Node Right;

        public Node(int value, Node parentNode)
        {
            Value = value;
            ParentNode = parentNode;
            Left = null;
            Right = null;
        }

        public object Clone()
        {
            var newNode = (Node) this.MemberwiseClone();
            newNode.Value = this.Value;
            newNode.ParentNode = this.ParentNode;
            newNode.Left = this.Left;
            newNode.Right = this.Right;

            return newNode;
        }

        public Node CloneNode()
        {
            var newNode = (Node) this.MemberwiseClone();
            newNode.Value = this.Value;
            newNode.ParentNode = this.ParentNode;
            newNode.Left = this.Left;
            newNode.Right = this.Right;

            return newNode;
        }
    }
}