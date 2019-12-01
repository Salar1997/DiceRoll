using System;
using System.Collections.Generic;
using System.Text;

namespace EventApp
{
    class Player
    {
        private int score; // declarate a score variable 

        public void AddScore(int points) // collect and Addition the score
        {
            score = score + points;
        }
        public int GetScore() // gets score from roll
        {
            return score;
        }
    }
}
