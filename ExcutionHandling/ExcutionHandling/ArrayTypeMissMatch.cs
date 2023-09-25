using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcutionHandling
{
    internal class ArrayTypeMissMatch
    {
        public void ArrayType()
        {
            string[] array =
            {
             "Manoj","Kumar","Naik"
            };
            int[] a =
            {
                1,2
            };
            try
            {
                Array.Copy(array, a, 2);

            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
