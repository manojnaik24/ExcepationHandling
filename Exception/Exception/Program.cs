using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Program
    {
        //A problem that occurs during the  excution of a program is refer to as an excution
        //It allow to control a passed from one part of the programe to the another exception
        //It will prevent the crashing of the programe
        static void Main(string[] args)
        {
            Division d=new Division();
            d.Num();
            Console.ReadLine();
        }
    }
}
