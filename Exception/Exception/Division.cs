using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Division
    {
        public void Num()
        {
            int a = 0;
            //if (a != 0)
            //{
            //    int b = 10 / a;
            //    Console.WriteLine(b);
            //}
            try
            {
                int b = 10 / a;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
