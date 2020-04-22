using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int result = 0;

            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());

            result = dice.RollDice(size);
            Console.WriteLine("The number is: " + result);

            Console.ReadLine();
        }
    }
}
