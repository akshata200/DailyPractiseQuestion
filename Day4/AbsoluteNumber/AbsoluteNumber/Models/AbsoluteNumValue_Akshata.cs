using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteNumber.Models
{
    internal class AbsoluteNumValue_Akshata
    {
        int inputNum;

        public AbsoluteNumValue_Akshata()
        {
            this.inputNum = 0;
        }

        /// <summary>
        /// Executor code for taking input and printing Absolute Value
        /// </summary>
        public void Executor()
        {
            TakeInput();
        }

        /// <summary>
        /// Input Integer from console
        /// </summary>
        public void TakeInput()
        {
            Console.WriteLine("Input a number");
            try
            {
                this.inputNum = int.Parse(Console.ReadLine());
                PrintAbsoluteValue();
            }
            catch (Exception e) 
            { 
                Console.WriteLine("Invalid input : "+e.Message);
            }
        }

        /// <summary>
        /// Print Absolute value of input integer
        /// </summary>
        public void PrintAbsoluteValue()
        {
            if (this.inputNum < 0)
                this.inputNum = this.inputNum * -1;
            Console.WriteLine($"Absolute value is {this.inputNum}");
        }
    }
}
