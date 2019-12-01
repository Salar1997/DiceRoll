using System;
using System.Collections.Generic;
using System.Text;

namespace EventApp
{
    class Dice
    {
        public int Roll() //generate a random int between 1-6
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
