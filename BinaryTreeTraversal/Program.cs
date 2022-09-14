using System;
using System.Collections.Generic;

// Non-recursive = Binary Tree InOrder Traversal

public class Node
{
    public int value;
    public Node left, right;

    public Node(int item)
    {
        value = item;
        left = right = null;
    }
}

public class BinaryTree
{
    public Node root;
    public virtual void InOrderTraversal()
    {
        if (root == null)
        {
            return;
        }

        Stack<Node> s = new Stack<Node>();
        Node current = root;

        //Traverse the tree
        while (current != null || s.Count > 0)
        {
            // Reach the left most Node of the curr Node 
            while (current != null)
            {
                s.Push(current);
                current = current.left;
            }
            // Current must be NULL at this point 
            current = s.Pop();
            Console.Write(current.value + " ");
            current = current.right;
        }
    }

    public static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);
        tree.InOrderTraversal();
    }
}