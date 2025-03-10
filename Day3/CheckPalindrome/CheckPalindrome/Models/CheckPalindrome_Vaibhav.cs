using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome.Models
{
    internal class CheckPalindrome_Vaibhav
    {
        string? s = string.Empty;
        List<char> ls = new List<char>();
        public string IsPalindrome()
        {
            s = TakeInput();

            for (int j=0;j< s.Length;j++)
            {
                if (char.IsLetterOrDigit(s[j]))
                {
                    ls.Add(s[j]);
                }
            }
            
            for (int i = 0; i < ls.Count / 2; i++)
            {
                if (ls[i] != ls[ls.Count - 1 - i])
                    return "It is not palindrome";
            }
            
            
            return "It is palindrome";
        }
        public string TakeInput()
        {
            Console.WriteLine("Input : ");
            s = Console.ReadLine();
            return string.IsNullOrEmpty(s) ? string.Empty: s;
        }
    }
}
