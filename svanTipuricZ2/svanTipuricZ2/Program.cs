using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite string vrijednost: " );
            string a = Console.ReadLine();
            a = a.Replace(" ", "_");
            /*
            for ( int i = 0; i< a.Length; i++)
            {
                if (a.Substring(i,1) == " ")
                {
                    a.Remove(i, 1);
                    a.Insert(i, "_");
                    
                }
            }*/
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
