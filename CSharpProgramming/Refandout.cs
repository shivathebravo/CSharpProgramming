using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
  /// <summary>
  ///  Ref cause an argument to be passed by reference  but must be initialized to the source objecct
  ///  Out cause an argument to be passed bt reference but do not need to be initialized
  /// </summary>
  public  class Refandout
    {
      public  void OutMethod(out string outString)
      {
          outString = "THis is the new outstring value";
      }

      public  void refMethod(ref string refString)
      {
          refString = "This is referenceMethod string";
      }
    }
}
