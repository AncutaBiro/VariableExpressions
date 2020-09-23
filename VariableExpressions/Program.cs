using System;

namespace VariableExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            byte x = 250;
            byte y = 10;
            x = (byte)(x + y);
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
