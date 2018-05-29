using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
  class Program
  {
    static void Main(string[] args)
    {
      //MultiSetSortedLinkedList neu = new SetSortedLinkedList();
      //neu.Insert(3);
      //neu.Insert(2);
      //neu.Insert(4);
      //neu.Insert(1);
      //neu.Insert(1);
      //neu.Insert(1);
      //neu.Insert(7);
      //Console.WriteLine(neu.Search(79));
      //neu.Insert(7);
      //neu.Insert(7);
      //neu.Insert(5);
      //neu.Insert(6);
      //Console.WriteLine(neu.Insert(7));
      //Console.WriteLine(neu.Insert(1));
      //neu.Insert(4);
      ////neu.DeleteAll(1);
      ////neu.DeleteAll(7);
      //neu.Delete(7);
      //neu.Delete(1);
      //neu.Delete(7);
      //Console.WriteLine(neu.Delete(7));
      //neu.Insert(-8);
      //neu.Print();
      //Console.WriteLine(neu.Search(5));


      /* Zum Testen vom BinSearchTree*/
      BinSearchTree tree = new BinSearchTree();
      /*
      tree.Insert(5);
      tree.Insert(1);
      tree.Insert(3);
     tree.Insert(8);
      tree.Insert(6);
      tree.Insert(0);
     tree.Insert(2);
      tree.Insert(4);
      tree.Insert(19);
      tree.Insert(29);
      tree.Insert(28);
      tree.Insert(30);
      tree.Insert(26);*/
     tree.Insert(1);
      //tree.Insert(-3);
      //tree.Insert(-2);
      //tree.Insert(-4);
      //tree.Insert(-6);
      //tree.Insert(-9);
      //tree.Insert(-5);
      //tree.Insert(-7);
      //WriteLine(tree.Insert(8));
      //WriteLine(tree.Insert(0));

      tree.Print();

      tree.Delete(1);

      tree.Print();
      //Console.WriteLine(tree.Search(9));
      //Console.WriteLine(tree.Search(1));
      //Console.WriteLine(tree.Search(6));
      //tree.Printv();

      
      /*
      SetUnsortedArray ar = new SetUnsortedArray();
      Console.WriteLine(ar.Insert(3));
      Console.WriteLine(ar.Insert(2)) ;
      Console.WriteLine(ar.Insert(3));
      Console.WriteLine(ar.Insert(5));
      Console.WriteLine(ar.Delete(3));
      Console.WriteLine(ar.Insert(5));
      ar.Print();
      Console.ReadKey();
      */
    }
  }
}
