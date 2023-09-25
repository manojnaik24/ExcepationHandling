using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class FileNotFoundExcetions
    {
        public void Efile()
        {
            var file = "Naik.txt";
            try
            {
                var text = File.ReadAllText(file);
            }
            catch(FileNotFoundException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
