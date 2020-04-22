using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        Random random = new Random();
        public int RollDice(int size)
        {
            int randomNumber = random.Next(1, size + 1);
            return randomNumber;
        }
    }
}
