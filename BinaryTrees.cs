﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{

  class BinSearchTree : BinaryTree, ISetSorted
  {   
    public BinSearchTree()    //Ich glaub das ist eh default-Einstellung (Eugen)
    {
      root = null;
    }
  
    public void Print()
    {
      Node current = root;

      if (current != null)
      {
        Inorder(current);
        Console.WriteLine();
        Preorder(current);
        Console.WriteLine();
        Postorder(current);
        Console.WriteLine();
      }
    }
    public bool Search(int elem)
    {
      if (_search(elem) != null)
        return true;

      return false;
    }

    
    public virtual bool Insert(int data)
<<<<<<< HEAD
=======
    {
      Node newItem = new Node(data);

      if (root == null)
      {
        root = newItem;
        return true;
      }

      else
      {
        Node current = root;

        Node parent = null;
        while (current != null)
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
        {
          Node newItem = new Node(data);

          if (root == null)
          {
            root = newItem;
            return true;
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
          return false;
        }
        /*
        {
            if (root == null)               //Neue Wurzel
            {
                root = new Node(data);
                return true;
            }

            Node tmp = new Node(data);      //Sonst
            Node tmp_parent = _searchPosAbove(data); //n = Vorgänger

            if (tmp_parent != null)
            {
                tmp.parent = tmp_parent;

                if (tmp_parent.data < data)
                    tmp_parent.right = tmp;
                else
                    tmp_parent.left = tmp;

                return true;
            }
            return false;
        }*/

        public virtual bool Delete(int data)
    {
      if (root == null)
      {
        return false;
      }

      Node current = _search(data);
      if (current == null) return false;
      Node parent = _searchPosAbove(data);          

      //Case 1: The current has no children
      if (current.left == null && current.right == null)
      {
        if (parent == null)
        {
          root = null;
         
        }
        else if (parent.data > current.data)
        {
          parent.left = null;
        }
        else if (parent.data < current.data)
        {
          parent.right = null;
        }
        current = null;
      }

      //Case 2: The current has no left child
      else if (current.left == null)
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
      else if (current.right == null)
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
      else if (current.right != null && current.left != null)
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
  }
    /*
   class AVLTree : BinSearchTree
  {
    public override bool Insert(int data)
    {
      return false;
    }

    public override bool Delete(int data)
    {
      return false;
    }
  }

   class Treap : BinSearchTree
  {
    public override bool Insert(int data)
    {
      return false;
    }

    public override bool Delete(int data)
    {
      return false;
    }
  }*/
}
