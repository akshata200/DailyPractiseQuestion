using CheckPalindrome.Models;

namespace CheckPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("\n------------------------------------------------------------\n");

            CheckPalindrome_Akshata chPalAk = new CheckPalindrome_Akshata();
            chPalAk.Executor();

            Console.WriteLine("\n------------------------------------------------------------\n");

            CheckPalindrome_Vaibhav vda = new CheckPalindrome_Vaibhav();
            Console.WriteLine(vda.IsPalindrome());

            Console.WriteLine("\n------------------------------------------------------------\n");
        }
    }
}
