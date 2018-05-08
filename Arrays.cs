using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDat
{
  class MultiSetUnsortedArray : Array, IMultiSet
  {
    
  }

  class SetUnsortedArray : MultiSetUnsortedArray, ISet
  {

  }

  class MultiSetSortedArray : Array, IMultiSetSorted
  {

  }

  class SetSortedArray : MultiSetSortedArray, IMultiSetSorted
  {

  }
}
