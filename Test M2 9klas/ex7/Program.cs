using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            
            int[,] array = new int[n,k];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int f = 0; f < k; f++)
                {
                    array[i, f] = r.Next(0,30);
                }
            }
            Console.ReadLine();
        }
    }
}
