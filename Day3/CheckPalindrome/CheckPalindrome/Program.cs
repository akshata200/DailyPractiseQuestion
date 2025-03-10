using CheckPalindrome.Models;

namespace CheckPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome_Vaibhav vda = new CheckPalindrome_Vaibhav();
            Console.WriteLine(vda.IsPalindrome("abcddcba"));
            Console.WriteLine(vda.IsPalindrome("abcdcda"));
        }
    }
}
