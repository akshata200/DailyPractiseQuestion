using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame.Models
{
    internal class RandomNumberGame_Vaibhav
    {
        int a, b, c;
        Random ra;
        int winCount;

        public RandomNumberGame_Vaibhav()
        {
            ra = new Random();
        }
        public void GenerateRandomNumber()
        {
            a = ra.Next(11);
            b = ra.Next(11);
            c = ra.Next(11);
            Console.WriteLine("First Number = " + a);
            Console.WriteLine("Second Number = " + b);
            Console.WriteLine("Third Number = " + c);
        }
        public string GetResult()
        {
            if (a % 2==0)
            {
                winCount++;
            }
            if (b % 2 == 0)
            {
                winCount++;
            }
            if (c % 2 == 0)
            {
                winCount++;
            }
            if (winCount > 1)
                return "You won";

            return "You Lost";
        }
    }
}
