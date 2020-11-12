using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite vrijednost za 3 stringa: ");
            string[] a = new string[]
            {
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
            };
            Array.Sort(a);
            foreach(string s in a)
            {
                Console.WriteLine(s);
            }
           
            Console.ReadKey();
        }
    }
}
