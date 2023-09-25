using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcutionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexOutOfRange i=new IndexOutOfRange();
            i.Range();

            ArrayTypeMissMatch am=new ArrayTypeMissMatch();
            am.ArrayType();
            
            Console.ReadLine();


        }
    }
}
