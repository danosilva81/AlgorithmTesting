using System;

namespace TenerifeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qué vuelta, mosquets.");
            var numSolution = new NumericSolution();
            int a = 12345;
            Console.WriteLine(numSolution.FrontBackNumbers1(a));
            Console.ReadLine();
        }
    }
}
