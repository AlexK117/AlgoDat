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
<<<<<<< HEAD
      do
      {
        Console.WriteLine("Welceh Datenstruktur möchten Sie testen?");
        Console.WriteLine("Array  --> 1");
        Console.WriteLine("Liste  --> 2");
        Console.WriteLine("Baum   --> 3");
        Console.WriteLine("Hash   --> 4");

        var i = Convert.ToInt32(ReadLine());
=======
      int switch_on = 0;
      do
      {
          Console.WriteLine("Welche Datenstruktur möchten Sie testen?");
          Console.WriteLine("Array  --> 1");
          Console.WriteLine("Liste  --> 2");
          Console.WriteLine("Baum   --> 3");
          Console.WriteLine("Hash   --> 4");
        try
        {
          switch_on = Convert.ToInt32(ReadLine());
        }
        catch (System.FormatException) { switch_on = 0; }
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f

        IDictionary Test = null;
        string datastruct = "";

<<<<<<< HEAD
        switch (i)
=======
        switch (switch_on)
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
        {
          case 1:
            datastruct = "Array";
            Console.WriteLine($"Welche Art von {datastruct} möchten sie testen?");
            Console.WriteLine("MultiSetUnsorted  --> 1");
            Console.WriteLine("MultiSetSorted    --> 2");
            Console.WriteLine("SetUnsorted       --> 3");
            Console.WriteLine("SetSorted         --> 4");
<<<<<<< HEAD
            i = Convert.ToInt32(ReadLine());
            switch (i)
            {
              case 1:
                Test = new MultiSetUnsortedLinkedList();
                break;
              case 2:
                Test = new MultiSetSortedLinkedList();
=======
            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 0; }

            switch (switch_on)
            {
              case 1:
                Test = new MultiSetUnsortedArray();
                break;
              case 2:
                Test = new MultiSetSortedLinkedList();    //Ändern, wenn Arrays fertig
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
                break;
              case 3:
                Test = new SetUnsortedLinkedList();
                break;
              case 4:
                Test = new SetSortedLinkedList();
                break;

              default:
<<<<<<< HEAD
                Console.WriteLine("Nö");
=======
                switch_on = 0;
                Console.WriteLine("Nö\n");
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
                break;
            }
            break;

          case 2:
            datastruct = "Liste";
            Console.WriteLine($"Welche Art von {datastruct} möchten sie testen?");
            Console.WriteLine("MultiSetUnsorted  --> 1");
            Console.WriteLine("MultiSetSorted    --> 2");
            Console.WriteLine("SetUnsorted       --> 3");
            Console.WriteLine("SetSorted         --> 4");
<<<<<<< HEAD
            i = Convert.ToInt32(ReadLine());
            switch (i)
=======
            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 0; }

            switch (switch_on)
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
            {
              case 1:
                Test = new MultiSetUnsortedLinkedList();
                break;
              case 2:
                Test = new MultiSetSortedLinkedList();
                break;
              case 3:
                Test = new SetUnsortedLinkedList();
                break;
              case 4:
                Test = new SetSortedLinkedList();
                break;
<<<<<<< HEAD
              default:
                Console.WriteLine("Nö");
=======

              default:
                switch_on = 0;
                Console.WriteLine("Nö\n");
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
                break;
            }
            break;

          case 3:
            datastruct = "Baum";
            Console.WriteLine($"Welche Art von {datastruct} möchten sie testen?");
            Console.WriteLine("BinarySearchTree  --> 1");
            Console.WriteLine("Treap             --> 2");
            Console.WriteLine("AVL               --> 3");
<<<<<<< HEAD
            i = Convert.ToInt32(ReadLine());
            switch (i)
=======
            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 0; }

            switch (switch_on)
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
            {
              case 1:
                Test = new BinSearchTree();
                break;
              case 2:
                Test = new Treap();
                break;
              case 3:
                Test = new AVLTree();
                break;
              default:
<<<<<<< HEAD
                Console.WriteLine("Nö");
                break;
            }
            break;
          case 4:
            datastruct = "Hash";
            break;

          default:
            Console.WriteLine("Nö");
            break;
        }

        string s = "";
        do
        {
          Console.WriteLine("Welche Operation soll es denn sein? ('0' zum ändern der Struktur)");
          Console.WriteLine("Einfugen  --> 1");
          Console.WriteLine("Suchen    --> 2");
          Console.WriteLine("Loschen   --> 3");
          Console.WriteLine("Ausgeben  --> 4");

          i = Convert.ToInt32(ReadLine());


          switch (i)
          {
            case 1:
              Console.WriteLine("Geben sie die Zahlen zum Einfügen ein (zum ändern der Operation 'a' drücken)");
              s = ReadLine();
              while (s != "a")
              {
                Console.WriteLine(Test.Insert(Convert.ToInt32(s)));
                s = ReadLine();
              }
              break;
            case 2:
              Console.WriteLine("Geben sie die Zahlen zum Suchen ein (zum ändern der Operation 'a' drücken)");
              s = ReadLine();
              while (s != "a")
              {
                Console.WriteLine(Test.Search(Convert.ToInt32(s)));
                s = ReadLine();
              }
              break;
            case 3:
              Console.WriteLine("Geben sie die Zahlen zum Löschen ein (zum ändern der Operation 'a' drücken)");
              s = ReadLine();
              while (s != "a")
              {
                Console.WriteLine(Test.Delete(Convert.ToInt32(s)));
                s = ReadLine();
              }
              break;
            case 4:
              Console.WriteLine();
              Test.Print();
              Console.WriteLine();
              break;
            case 0:
              s = "N";
              break;

            default:
              Console.WriteLine("Nö");
              break;
          }
        }
        while (s != "N");
      }
      while (true);
=======
                switch_on = 0;
                Console.WriteLine("Nö\n");
                break;
            }
            break;

          case 4:
            datastruct = "Hash";
            Console.WriteLine($"Welche Art von {datastruct} möchten sie testen?");
            Console.WriteLine("BinarySearchTree  --> 1");
            Console.WriteLine("Treap             --> 2");
            Console.WriteLine("AVL               --> 3");
            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 0; }

            switch (switch_on)
            {
              case 1:
                Test = new BinSearchTree();     //Anpassen, wenn Hash fertig
                break;
              case 2:
                Test = new Treap();
                break;

              default:
                switch_on = 0;
                Console.WriteLine("Nö\n");
                break;
            }
            break;

          default:
            switch_on = 0;
            Console.WriteLine("Nö\n");
            break;
        }

        if (switch_on != 0)
        {
          string s = "";
          do
          {
            Console.WriteLine("Welche Operation soll es denn sein? ('0' zum ändern der Struktur)");
            Console.WriteLine("Einfugen  --> 1");
            Console.WriteLine("Suchen    --> 2");
            Console.WriteLine("Loschen   --> 3");
            Console.WriteLine("Ausgeben  --> 4");

            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 50; }

            switch (switch_on)
            {
              case 1:
                Console.WriteLine("Geben sie die Zahlen zum Einfügen ein (zum ändern der Operation '+' drücken)");
                s = ReadLine();

                while (s != "+")
                {
                  try
                  {
                    Console.WriteLine(Test.Insert(Convert.ToInt32(s)));
                  }
                  catch (FormatException)
                  {
                    Console.WriteLine("Nur Zahlen eingeben:");
                  }
                  s = ReadLine();
                }
                break;
              case 2:
                Console.WriteLine("Geben sie die Zahlen zum Suchen ein (zum ändern der Operation '+' drücken)");
                s = ReadLine();

                while (s != "+")
                {
                  try
                  {
                    Console.WriteLine(Test.Search(Convert.ToInt32(s)));
                  }
                  catch (FormatException)
                  {
                    Console.WriteLine("Nur Zahlen eingeben:");
                  }
                  s = ReadLine();
                }
                break;
              case 3:
                Console.WriteLine("Geben sie die Zahlen zum Löschen ein (zum ändern der Operation '+' drücken)");
                s = ReadLine();

                while (s != "+")
                {
                  try
                  {
                    Console.WriteLine(Test.Delete(Convert.ToInt32(s)));
                  }
                  catch (FormatException)
                  {
                    Console.WriteLine("Nur Zahlen eingeben:");
                  }
                  s = ReadLine();
                }
                break;
              case 4:
                Console.WriteLine();
                Test.Print();
                Console.WriteLine();
                break;
              case 0:
                s = "OP_switch";
                break;

              default:
                Console.WriteLine("Nö\n");
                break;
            }
          }
          while (s != "OP_switch");
        }
      }
      while (true);   //Endlose wiederholung

>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
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
      //neu.DeleteAll(1);
      //neu.DeleteAll(7);
      //neu.Delete(7);
      //neu.Delete(1);
      //neu.Delete(7);
      //Console.WriteLine(neu.Delete(7));
      //neu.Insert(-8);
      //neu.Print();
      //Console.WriteLine(neu.Search(5));

      //BinSearchTree tree = new BinSearchTree();


<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
      //tree.Insert(1);
      //tree.Insert(3);
      //tree.Insert(8);
      //tree.Insert(6);
      //tree.Insert(0);
      //tree.Insert(2);
      //tree.Insert(4);
      //tree.Insert(19);
      //tree.Insert(29);
      //tree.Insert(28);
      //tree.Insert(30);
      //tree.Insert(26);
      //tree.Insert(-1);
<<<<<<< HEAD
>>>>>>> 3140439e47e0d5ca4a84fe56ea0ec9f3d6b3a1ed
=======
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
      //tree.Insert(-3);
      //tree.Insert(-2);
      //tree.Insert(-4);
      //tree.Insert(-6);
      //tree.Insert(-9);
      //tree.Insert(-5);
      //tree.Insert(-7);
      //WriteLine(tree.Insert(8));
      //WriteLine(tree.Insert(0));
<<<<<<< HEAD
<<<<<<< HEAD

      tree.Print();

      tree.Delete(1);

      tree.Print();
=======
      //tree.Print();
>>>>>>> 3140439e47e0d5ca4a84fe56ea0ec9f3d6b3a1ed
=======
      //tree.Print();
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
      //Console.WriteLine(tree.Search(9));
      //Console.WriteLine(tree.Search(1));
      //Console.WriteLine(tree.Search(6));
      //tree.Printv();
      //Console.ReadKey();
<<<<<<< HEAD

      
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
=======
>>>>>>> ca1b4af4d47dc26350abff7d803099fc0128d64f
    }
  }
}
