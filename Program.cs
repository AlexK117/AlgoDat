﻿using System;
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
      MultiSetSortedLinkedList neu = new MultiSetSortedLinkedList();
      neu.Insert(3);
      neu.Insert(2);
      neu.Insert(4);
      neu.Insert(1);
      neu.Insert(1);
      neu.Insert(1);
      neu.Insert(7);
      neu.Insert(7);
      neu.Insert(7);
      neu.Insert(5);
      neu.Insert(6);
      Console.WriteLine(neu.Insert(7));
      Console.WriteLine(neu.Insert(1));
      neu.Insert(4);
      //neu.DeleteAll(1);
      //neu.DeleteAll(7);
      //neu.Delete(7);
      //neu.Delete(1);
      //neu.Delete(7);
      //Console.WriteLine(neu.Delete(7));
      neu.Insert(-8);
      Console.WriteLine(neu[0]);
      neu[0] = 8;
      neu.Print();
      //Console.WriteLine(neu.Search(5));
        Console.ReadKey();
    }
  }
}