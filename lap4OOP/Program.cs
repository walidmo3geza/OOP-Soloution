using System;

namespace lap4OOP
{
    internal class Program
    {
        public static void swap(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
        public static long calc_power(int _base, int power)
        {
            long res = 1;
            if (power > 0)
            {
                res = _base * calc_power(_base, --power);
            }
            return res;
        }
        public static long calc_factorial(int num)
        {
            long res = 1;
            if (num > 1)
            {
                res = num * calc_factorial(num - 1);
            }
            return res;
        }
        static void Main(string[] args)
        {
            int x, y;

            //swap

            Console.Write("Enter first number : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            y = int.Parse(Console.ReadLine());
            swap(ref x, ref y);
            Console.WriteLine($"The value of first number after SWAP = {x}");
            Console.WriteLine($"The value of second number after SWAP = {y}");

            //power

            Console.Write("Enter BASE number : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter POWER number : ");
            y = int.Parse(Console.ReadLine());
            long result = calc_power(x, y);
            Console.WriteLine($"The value of {x} power {y} = {result}");


            ////factorial by using recursion

            Console.Write("Enter number : ");
            x = int.Parse(Console.ReadLine());
            long res = calc_factorial(x);
            Console.WriteLine($"The factorial of {x} = {res}");

            //factorial by iterative

            Console.Write("Enter number : ");
            x = int.Parse(Console.ReadLine());
            long re = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"The factorial of {x} = {re}");
        }
    }
}
