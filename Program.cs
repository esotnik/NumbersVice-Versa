using System;

namespace NumbersViceVersa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;

            Console.WriteLine($"{a}-{b}");

            (a, b) = (b, a); // обмен

            Console.WriteLine($"{a}-{b}");
        }
    }
}
