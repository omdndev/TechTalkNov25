// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Interfaces;

Console.WriteLine("Hello, World!");


ICalc calc = new Calc();
Console.WriteLine(calc.Add(4, 0));
Console.WriteLine(calc.Subtract(4, 0));
Console.WriteLine(calc.Divide(4, 0));

string result = "";
for (int i = 0; i < 10000; i++)
{
    result += i;
}

Console.WriteLine(result[..10]);