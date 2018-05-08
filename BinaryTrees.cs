using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
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

      return false;
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

    public void Printv()
    {
      PrintVisual();
    }
  }

  class AVLTree : BinSearchTree
  {

  }

  class Treap : BinSearchTree
  {

  }
}
