using System;

namespace ConsoleUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Service();
            Console.WriteLine(s.Add(5, 10));
            Console.WriteLine(s.Subtract(8, 2));
            Console.WriteLine(s.Multiply(5, 7));
            Console.WriteLine(s.Divided(10.0, 3.0));
            Console.ReadLine();
        }
    }
}
