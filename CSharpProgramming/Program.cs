using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Refandout reference=new Refandout();
            string outString = "This is the original Outstring";
            reference.OutMethod(out outString);
            Console.WriteLine(outString);
            Console.ReadLine();

            //string refString = "This is the original ref string";
            //Console.WriteLine(refString);
            //reference.refMethod(ref refString);
            //Console.WriteLine(refString);
            //Console.ReadLine();
        }
    }
}
