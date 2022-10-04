using System;

namespace lap2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////
            //task 1 problem 1//
            ////////////////////


            int min = 0, max = 0, num;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Please Enter number {i}: ");
                num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    min = num;
                    max = num;
                }
                else
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }
            Console.WriteLine($"The maximum value is : {max}");
            Console.WriteLine($"The minimum value is : {min}");


            ////////////////////
            //task 1 problem 2//
            ////////////////////

            double a, b, c, value_under_square_route, x1, x2;
            Console.Write($"Please Enter The Value Of a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write($"Please Enter The Value Of b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write($"Please Enter The Value Of c : ");
            c = double.Parse(Console.ReadLine());
            value_under_square_route = b * b - 4 * a * c;
            //Console.WriteLine(value_under_square_route);
            if (value_under_square_route == 0)
            {
                x1 = (-1 * b) / (2 * a);
                x2 = (-1 * b) / (2 * a);
                Console.WriteLine($"The Value Of X1 = {x1}");
                Console.WriteLine($"The Value Of X2 = {x2}");
            }
            else if (value_under_square_route < 0)
            {
                x1 = (-1 * b) / (2 * a);
                x2 = (-1 * b) / (2 * a);
                Console.WriteLine($"The Value Of X1 = {x1} + imaginary number");
                Console.WriteLine($"The Value Of X2 = {x2} - imaginary number");
            }
            else
            {
                double left = (-1 * b) / (2 * a);
                double rite = Math.Sqrt(value_under_square_route) / (2 * a);
                Console.WriteLine($"The Value Of X1 = {left} + {rite}");
                Console.WriteLine($"The Value Of X2 = {left} - {rite}");
            }
        }
    }
}
