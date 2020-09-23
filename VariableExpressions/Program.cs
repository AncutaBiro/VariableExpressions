using System;

namespace VariableExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 2;
            const int z = 5;
            const bool v = z < 10;
      
            Console.WriteLine(v);
            Console.Read();
        }
    }
}
