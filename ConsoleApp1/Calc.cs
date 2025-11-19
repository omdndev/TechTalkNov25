using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class Calc: ICalc
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }
}
