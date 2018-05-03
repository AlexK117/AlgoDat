using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
  abstract class List
  {
    protected class ListElement
    {
      public int elem;
      public ListElement prev, next;

      public ListElement(int Elem)
      {
        elem = Elem;
      }

      public static ListElement operator ++(ListElement le) => le.next;
      public static ListElement operator --(ListElement le) => le.prev;
    }
    protected ListElement start, end;

    public virtual bool Search(int elem)
    {
      return true;
    }
    public virtual bool Insert(int elem)
    {
      return true;
    }
    public virtual bool Delete(int elem)
    {
      return true;
    }
    public void Print()
    {
      for (ListElement tmp = start; tmp != null; tmp++)
        Console.WriteLine(tmp.elem);
    }

    /// <summary>
    /// Hilfsmethode zum Suchen
    /// </summary>
    /// <param name="elem"></param>
    /// <returns></returns>
    protected ListElement _search(int elem)
    {
      for (ListElement tmp = start; tmp != null; tmp++)
      {
        if (elem == tmp.elem)
          return tmp;
      }
      return null;
    }

    protected ListElement FindElemIndex(int index)
    {
      ListElement tmp = start;

      for (int i = 0; i < index; i++)
        tmp++;

      return tmp;
    }
    public int this[int Index]
    {
      get
      {
        return FindElemIndex(Index).elem;
      }

      set
      {
        FindElemIndex(Index).elem = value;
      }
    }

    public IEnumerator GetEnumerator()
    {
      for (ListElement tmp = start; tmp != null; tmp++)
        yield return tmp.elem;
    }
  }

  abstract class Array
  {

  }
  abstract class BinaryTree
  {
    protected class Node
    {
      public int elem;
      public Node left, right;

      public Node(int Elem)
      {
        elem = Elem;
      }
    }

    protected Node root;

    protected Node _search(int elem)
    {
      Node tmp = root;
        while (tmp != null && tmp.elem != elem )
        {
          if (elem < tmp.elem)
            tmp = tmp.left;
          else
            tmp = tmp.right;
        }
        return tmp;
    }
  }

  abstract class HashFkt : Array
  {

  }
}
