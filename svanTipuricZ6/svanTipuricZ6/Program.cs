using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(s[i]);
            }
            Console.WriteLine(n);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i] = arr[i + 1];
                    arr[i] = temp;
                }

                Console.Write(arr[i]);
            }
        }
    }
}
