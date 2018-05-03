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
      if (root == null)
      {
        root = new Node(elem);
        return true;
      }

      Node tmp = root, b = null;

      while (tmp != null && tmp.elem != elem)
      {
        b = tmp;

        if (elem < tmp.elem)
          tmp = tmp.left;
        else
          tmp = tmp.right;
      }

      if (tmp == null)
      {
        tmp = new Node(elem);

        if (b.elem < elem)
          b.right = tmp;
        else b.left = tmp;
      }
      else
        return false;

      return true;
    }
  }

  class AVLTree : BinSearchTree
  {

  }

  class Treap : BinSearchTree
  {

  }
}
