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
/*
=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
      do
      {
        Console.WriteLine("Welceh Datenstruktur möchten Sie testen?");
        Console.WriteLine("Array  --> 1");
        Console.WriteLine("Liste  --> 2");
        Console.WriteLine("Baum   --> 3");
        Console.WriteLine("Hash   --> 4");

        var i = Convert.ToInt32(ReadLine());
<<<<<<< HEAD

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

=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat

        IDictionary Test = null;
        string datastruct = "";

<<<<<<< HEAD

        switch (i)

        switch (switch_on)

=======
        switch (i)
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
        {
          case 1:
            datastruct = "Array";
            Console.WriteLine($"Welche Art von {datastruct} möchten sie testen?");
            Console.WriteLine("MultiSetUnsorted  --> 1");
            Console.WriteLine("MultiSetSorted    --> 2");
            Console.WriteLine("SetUnsorted       --> 3");
            Console.WriteLine("SetSorted         --> 4");
<<<<<<< HEAD

=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
            i = Convert.ToInt32(ReadLine());
            switch (i)
            {
              case 1:
                Test = new MultiSetUnsortedLinkedList();
                break;
              case 2:
                Test = new MultiSetSortedLinkedList();
<<<<<<< HEAD

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

=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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

                switch_on = 0;
                Console.WriteLine("Nö\n");

=======
                Console.WriteLine("Nö");
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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

            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 0; }

            switch (switch_on)

=======
            i = Convert.ToInt32(ReadLine());
            switch (i)
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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


              default:
                switch_on = 0;
                Console.WriteLine("Nö\n");

=======
              default:
                Console.WriteLine("Nö");
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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

            try
            {
              switch_on = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException) { switch_on = 0; }

            switch (switch_on)

=======
            i = Convert.ToInt32(ReadLine());
            switch (i)
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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

=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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
<<<<<<< HEAD

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


=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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
=======
<<<<<<< HEAD
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
      /* Zum Testen vom BinSearchTree*/
      BinSearchTree tree = new BinSearchTree();
      
      tree.Insert(1);
      tree.Insert(3);
      tree.Insert(2);
            Console.WriteLine(tree.Insert(4));
    /* tree.Insert(8);
      tree.Insert(6);
      tree.Insert(0);
     tree.Insert(2);
      tree.Insert(4);
      tree.Insert(19);
      tree.Insert(29);
      tree.Insert(28);
      tree.Insert(30);
<<<<<<< HEAD
      tree.Insert(26);

=======
      tree.Insert(26);*/
     tree.Insert(1);
=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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

=======
>>>>>>> 3140439e47e0d5ca4a84fe56ea0ec9f3d6b3a1ed
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
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
*/
=======
<<<<<<< HEAD

>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
      tree.Print();

      tree.Delete(3);

      tree.Print();
<<<<<<< HEAD
            /*
      //tree.Print();

=======
=======
      //tree.Print();
>>>>>>> 3140439e47e0d5ca4a84fe56ea0ec9f3d6b3a1ed
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
      //Console.WriteLine(tree.Search(9));
      //Console.WriteLine(tree.Search(1));
      //Console.WriteLine(tree.Search(6));
      //tree.Printv();
      //Console.ReadKey();
<<<<<<< HEAD

=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat

      
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
<<<<<<< HEAD

=======
>>>>>>> parent of 52ac3fa... Merge branch 'master' of https://github.com/AlexK117/AlgoDat
    }
  }
}

