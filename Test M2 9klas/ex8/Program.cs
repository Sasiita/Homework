using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The area of the circle is: " + AreaOfCircle(double.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        static double AreaOfCircle(double r)
        {
            double answer = Math.PI * (r * 2);
            return answer;
        }
    }
}
