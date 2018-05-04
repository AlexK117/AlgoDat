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
}
