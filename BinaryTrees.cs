using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
  public class Node
  {
    public int data;
    public int key;

    public Node left { get; set; }
    public Node right { get; set; }

    public Node() { }

    public Node(int Data)
    {
      data = Data;
    }

    public Node(int Data, int Key)
    {
      data = Data;
      key = Key;
    }
  }

  public class BinSearchTree : Node
  {
    private Node root;

    public BinSearchTree()
    {
      root = null;
    }

    public void Print()
    {
      if (root != null)
      {
        InOrderRecursiveTreeDisplay(root);
      }
    }

<<<<<<< HEAD
    public void InOrderRecursiveTreeDisplay(Node current)
    {
      if (current != null)
      {
        InOrderRecursiveTreeDisplay(current.left);
        Console.Write("({0})", current.data);
        InOrderRecursiveTreeDisplay(current.right);
      }
    }

    public bool Search(int data)
    {
      bool isFound = false; ;
      Node current = root;
      while (current != null)
      {
        if (current.data == data)
        {
          isFound = true;
        }
        if (data < current.data)
        {
          if (current.left != null)
          {
            current = current.left;
          }
          else { break; }
        }

        if (data > current.data)
        {
          if (current.right != null)
          {
            current = current.right;
          }
          else { break; }
        }
      }
      if (isFound) return true;
      else return false;
    }

    public virtual bool Add(int data)
    {
      Node newItem = new Node(data);

      if (root == null)
      {
        root = newItem;
      }

      else
      {
        Node current = root;

        Node parent = null;
        while (current != null)
        {
          parent = current;
          if (data < current.data)
          {
            current = current.left;
            if (current == null)//if the current.left is null
            {
              parent.left = newItem;//make parent.left store the new node
              return true;
            }
          }
          else
          {
            current = current.right;
            if (current == null)
            {
              parent.right = newItem;
              return true;
            }
          }
        }
      }
=======
      Node tmp = new Node(elem);      //Neuer Knoten
      Node n = _searchPosAbove(elem); //n = Vorgänger

      if (n != null)
      {
        tmp.above = n;

        if (n.elem < elem)
        {
          n.right = tmp;
          return true;
        }
        else
        {
          n.left = tmp;
          return true;
        }
      }
      return false;
    }

    public bool Delete(int elem)
    {

>>>>>>> 243348b1702ff6feddab66ae2e9459cacd99a6d2
      return false;
    }

    public virtual bool Delete(int data)
    {
      bool isFound = false;
      if (root == null)
      {
        return false;
      }

      Node current = root;
      Node parent = null;

      while (current != null && !isFound)
      {

        if (data < current.data)
        {
          parent = current;
          current = current.left;
        }
        else if (data > current.data)
        {
          parent = current;
          current = current.right;
        }
        if (current == null) return false;
        else isFound = true;
      }

      //Case 1: The current has no children
      if (current.left == null && current.right == null)
      {
        current = null;
      }

      //Case 2: The current has no left child
      if (current.left == null)
      {
        if (parent == null)
        {
          root = current.right;
        }

        else
        {
          if (parent.data > current.data)
          {
            parent.left = current.right;
          }
          else if (parent.data < current.data)
          {
            parent.right = current.right;
          }
        }
      }

      //Case 3: The current has no right child
      if (current.right == null)
      {
        if (parent == null)
        {
          root = current.left;
        }

        else
        {
          if (parent.data > current.data)
          {
            parent.left = current.left;
          }
          else if (parent.data < current.data)
          {
            parent.right = current.left;
          }
        }
      }

      //Case 4: The current has a left an a right child: Replace current with node with smallest value in left subtree
      if (current.right != null && current.left != null)
      {
        Node mostright = current.left.right;
        Node mrparent = current.left;

        if (mostright != null)
        {
          while (mostright.right != null)
          {
            mrparent = mostright;
            mostright = mostright.right;
          }

          //mrparents right subtree becomes mostrights left subtree
          mrparent.right = mostright.left;

          mostright.left = current.left;
          mostright.right = current.right;

          if (parent == null)
          {
            root = mostright;
          }
          else
          {
            if (parent.data > current.data)
            {
              parent.left = mostright;
            }
            if (parent.data < current.data)
            {
              parent.right = mostright;
            }
          }
        }
        else
        {
          parent.left = current.left;
        }
      }
      return true;
    }

    public void Printv()
    {
      PrintVisual();
    }
  }

  public class AVLTree : BinSearchTree
  {
    public override bool Add(int data)
    {
      return false;
    }

    public override bool Delete(int data)
    {
      return false;
    }
  }

  public class Treap : BinSearchTree
  {
    public override bool Add(int data)
    {
      return false;
    }

    public override bool Delete(int data)
    {
      return false;
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
    }
  }
  /*
    class BinSearchTree : BinaryTree, ISetSorted
    {
      public bool Search(int elem)
      {
        if (_search(elem) != null)
          return true;

        return false;
      }

      public bool Insert(int elem)
      {
        if (root == null)               //Neue Wurzel
        {
          root = new Node(elem);
          return true;
        }

        Node tmp = new Node(elem);      //Sonst
        Node n = _searchPosAbove(elem); //n = Vorgänger

        tmp.above = n;

        if (n.elem < elem)
          n.right = tmp;
        else
          n.left = tmp; 

        return true;
      }

      public void Print()
      {
        Node n = root;

        Inorder(n);
        Console.WriteLine();
        Preorder(n);
        Console.WriteLine();
        Postorder(n);
        Console.WriteLine();
      }
    }

    class AVLTree : BinSearchTree
    {

    }

    class Treap : BinSearchTree
    {

    }
    */


}
