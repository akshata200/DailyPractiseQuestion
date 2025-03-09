// See https://aka.ms/new-console-template for more information
using CalculatorProject.Model;

Console.WriteLine("Hello, World!");
Console.WriteLine("--------------------------------------");

//Calculator_Akshata calA = new Calculator_Akshata(2, 3);

Calculator_Vaibhav cls = new Calculator_Vaibhav();
// Addition
Console.WriteLine("Addition of 30 and 20 is " + cls.Add(30, 20));
// Substraction
Console.WriteLine("Substraction of 30 and 20 is " + cls.Subtract(30, 20));
// Multiplication
Console.WriteLine("Multiplication of 30 and 20 is " + cls.Multiply(30, 20));
// Division
Console.WriteLine("Division of 30 and 20 is " + cls.Division(40, 20));

Console.WriteLine("--------------------------------------");

Calculator_Akshata calA = new Calculator_Akshata(6, 3);
calA.Executor();