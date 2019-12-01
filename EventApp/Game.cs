using System;
using System.Collections.Generic;
using System.Text;

namespace EventApp
{
    class Game
    {
        private Player player = new Player(); //  place list 
        private Dice dice = new Dice(); //dice list

        public void Start() //everything in this class runs in Start
        {
            ShowMenu();
            
        }
        private void ShowMenu() // opitions menu
        {
            Console.WriteLine("|||||||Welcome to the dice roll||||||");
            Console.WriteLine("*****Choose a Opition*****");


            while (true) // here runs everything in while loop 
            {
                Console.WriteLine("Opitions");
                Console.WriteLine("1. Roll Dice");
                Console.WriteLine("2. Show Score");
                Console.Write("Select: ");
                string input = Console.ReadLine();
                Console.WriteLine("Selected: " + input);

                if (input == "1") // if input = 1 player get new int between 1-6
                {
                    RollDice();
                }
                else if(input == "2") // if input = 2 player gets score from the roll rounds 
                {
                    ShowScore();
                    break;
                }
            }
       
        }
        
        private void ShowScore() // gets players score 
        {
            int score = player.GetScore();
            Console.WriteLine("Your score: " + score);
        }

        private void RollDice() // rolls a dice and gets result from dice then it adds to player score
        {
            int result = dice.Roll();
            Console.WriteLine("Result: " + result);
            player.AddScore(result);
        }
    }
}
