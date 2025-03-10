using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome.Models
{
    internal class CheckPalindrome_Akshata
    {
        string inputString;
        bool isPalindrome;
        bool isValidInput;

        public CheckPalindrome_Akshata()
        {
            this.inputString = string.Empty;
            this.isPalindrome = false;
            this.isValidInput = false;
        }

        /// <summary>
        /// Executor method for checking Palindrome
        /// </summary>
        public void Executor()
        {
            TakeInput();
            if (this.isValidInput) 
            {
                if (isPalindrome)
                    Console.WriteLine("Is Palindrome");
                else
                    Console.WriteLine("Is Not Palindrome");
            }
        }

        /// <summary>
        /// Take input string for checking palindrome
        /// </summary>
        public void TakeInput()
        {
            string inpStr = string.Empty;

            Console.WriteLine("Input a string");
            inpStr = Console.ReadLine();
            if (inpStr!= null && inpStr.Length!=0 && IsAlphaNumeric(inpStr))
            {
                this.inputString = inpStr;
                this.isValidInput = true;
                this.isPalindrome = CheckPalindrome();
            }
            else
            {
                this.inputString = string.Empty;
                Console.WriteLine("Not a valid input");
            }
        }

        /// <summary>
        /// Check if given input is Valid or not i.e., only AplhaNumeric Characters
        /// </summary>
        /// <param name="inpStr"></param>
        /// <returns>True is input string is Valid</returns>
        public bool IsAlphaNumeric(string inpStr)
        {
            foreach(char c in inpStr)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Check if string is Palindorme or not
        /// </summary>
        /// <returns>True if input string is Palindrome</returns>
        public bool CheckPalindrome()
        {
            int i = 0, j = this.inputString.Length - 1;

            if (this.inputString.Length == 1)
                return true;
            while (i < j) {
                if (this.inputString[i] != this.inputString[j]) 
                    return false;
                i++;
                j--;
            }
            return true;
        }


    }
}
