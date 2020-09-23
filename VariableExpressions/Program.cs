using System;

namespace VariableExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            { 
                y += 9; 
            }
            int x = y + 2;
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
