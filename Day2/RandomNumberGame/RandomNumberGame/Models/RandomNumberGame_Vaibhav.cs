using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame.Models
{
    internal class RandomNumberGame_Vaibhav
    {
        int a;
        int b;
        int c;
        Random ra;
        int count;

        public RandomNumberGame_Vaibhav()
        {
            ra = new Random();
        }
        public void GenerateRandomNumber()
        {
            a = ra.Next(10);
            b = ra.Next(10);
            c = ra.Next(10);
            Console.WriteLine("First Number = " + a);
            Console.WriteLine("Second Number = " + b);
            Console.WriteLine("Third Number = " + c);
        }
        public string GetResult()
        {
            if (a % 2==0)
            {
                count++;
            }
            if (b % 2 == 0)
            {
                count++;
            }
            if (c % 2 == 0)
            {
                count++;
            }
            if (count > 1)
                return "You won";

            return "You Lost";
        }
    }
}
