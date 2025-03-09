using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Model
{
    internal class Calculator_Akshata
    {
        int num1, num2;
        public Calculator_Akshata(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public void Executor()
        {
            Add();
            Difference();
            Multiply();
            Divison();
        }

        /// <summary>
        /// Prints addition of two integer numbers
        /// </summary>
        public void Add()
        {
            int add = num1 + num2;
            Console.WriteLine($"Addition of {num1} and {num2} is {add}");
        }

        /// <summary>
        /// Prints difference of two integer numbers
        /// </summary>
        public void Difference()
        {
            int diff = num1 - num2;
            Console.WriteLine($"Difference of {num1} and {num2} is {diff}");
        }

        /// <summary>
        /// Prints multiplication of two integer numbers
        /// </summary>
        public void Multiply()
        {
            int mul = num1 * num2;
            Console.WriteLine($"Multiple of {num1} and {num2} is {mul}");
        }

        /// <summary>
        /// Prints divison of two integer numbers
        /// </summary>
        public void Divison()
        {
            int div = num2 != 0 ? num1 / num2 : 0;
            Console.WriteLine($"Division of {num1} and {num2} is {div}");
        }
    }
}
