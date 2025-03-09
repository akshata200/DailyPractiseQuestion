using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame.Models
{
    internal class RandomNumberGame_Akshata
    {
        int win = 0, lose = 0;
        public RandomNumberGame_Akshata() { }

        /// <summary>
        /// Play the Game
        /// </summary>
        public void Execute() 
        {
            PlayGame();
        }

        /// <summary>
        /// Generate random number
        /// </summary>
        /// <returns>return a random number</returns>
        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(11);
        }

        /// <summary>
        /// Check the random number 3 times and decide if player wins or loses
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine("Generated Random Number");
            for (int i = 0; i < 3; i++)
            {
                int randomNum = GenerateRandomNumber();
                Console.Write(randomNum+"   ");
                if (randomNum % 2 == 0) 
                    win++;
                else 
                    lose++;
            }
            if (win > lose)
                Console.WriteLine("\nHurray!! You Win the Game");
            else
                Console.WriteLine("\nOops!! You Lost the Game");
        }
    }
}
