// See https://aka.ms/new-console-template for more information
using RandomNumberGame.Models;

RandomNumberGame_Vaibhav cls = new RandomNumberGame_Vaibhav();
cls.GenerateRandomNumber();
Console.WriteLine("Result : " + cls.GetResult());


Console.WriteLine("--------------------------------------------");

RandomNumberGame_Akshata randomNumGameAk = new RandomNumberGame_Akshata();
randomNumGameAk.Execute();

Console.WriteLine("--------------------------------------------");