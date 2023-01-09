using System;

namespace bai1_day1
{
    internal class Program
    {
        static int Side;

        static int Roll(int s)
        {
            Random rd = new Random();
            return rd.Next(1, s + 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of sides: ");
            Side = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Son - 2. Le Thang - 3. Cong Hieu");
            Console.WriteLine($"Result of the rolling the Dice is {Roll(Side)} !");
        }
    }
}