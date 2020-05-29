using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Dice
    {
        Random x = new Random();
        public Dice(int sides)
        {
            x.Next(1,sides);
        }
    }
}
