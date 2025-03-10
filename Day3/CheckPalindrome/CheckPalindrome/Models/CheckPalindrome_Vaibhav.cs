using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome.Models
{
    internal class CheckPalindrome_Vaibhav
    {
        public string IsPalindrome(string s)
        {
            for (int i=0; i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return "It is not palindrome";
            }
            return "It is palindrome";
        }
    }
}
