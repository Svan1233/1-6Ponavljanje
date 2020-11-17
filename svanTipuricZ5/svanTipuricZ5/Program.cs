using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0;
            while (b < 31)
            {
                
                Console.WriteLine("Upisite vrijednost igrackih karata(1-13): ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a < 1 || a > 13)
                {
                    Console.WriteLine("Greska!");
                    break;
                }
                b = b + a;
                
                
            }
            if (b > 31)
            {
                Console.WriteLine("Izgubili ste!");

            }
            if (b == 31)
            {
                Console.WriteLine("Pobjedili ste!");

            }
            Console.ReadKey();
        }
    }
}
