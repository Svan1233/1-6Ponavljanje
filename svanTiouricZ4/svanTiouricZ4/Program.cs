using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTiouricZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite cijenu sa pdv-om: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite cijenu bez pdv-a: ");
            float b = Convert.ToInt32(Console.ReadLine());
            float c = a - b;
            Console.WriteLine("PDV je "+c);
            Console.ReadKey();
            
        }
    }
}
