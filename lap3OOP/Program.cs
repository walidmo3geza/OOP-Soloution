using System;

namespace lap3OOP
{
    internal class Program
    {
        public static int calc_curent_position_value(int size, int curent_row, int curent_column)
        {
            int value = -1, row = 1, column = (size + 1) / 2;

            if (curent_row == 1 && curent_column == ((size + 1) / 2))
            {
                value = 1;
            }
            else
            {
                for (int i = 2; i <= size * size; i++)
                {
                    if ((i - 1) % size == 0)
                    {
                        row++;
                        if (row > size)
                        {
                            row = 1;
                        }
                    }
                    else
                    {
                        row--;
                        column--;
                        if (row == 0)
                        {
                            row = size;
                        }
                        if (column == 0)
                        {
                            column = size;
                        }
                    }
                    if (row == curent_row && column == curent_column)
                    {
                        value = i;
                    }
                }
            }

            return value;
        }
        public static void print_row_and_column_for_numbers(int size)
        {
            int row = 1, column = (size + 1) / 2;
            for (int i = 1; i <= size * size; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"number = {i} row = {row} , column = {column}");
                }
                else
                {
                    if ((i - 1) % size == 0)
                    {
                        row++;
                        if (row > size)
                        {
                            row = 1;
                        }
                    }
                    else
                    {
                        row--;
                        column--;
                        if (row == 0)
                        {
                            row = size;
                        }
                        if (column == 0)
                        {
                            column = size;
                        }
                    }
                    Console.WriteLine($"number = {i} row = {row} , column = {column}");
                }
            }
        }
        static void Main(string[] args)
        {

            /////////////////
            //  problem 1  //
            /////////////////



            int max = 0, min = 0, inp, number_of_input;
            Console.Write("Please enter number of numbers you need to input it to calculate maximum and minimum numbers : ");
            number_of_input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number_of_input; i++)
            {
                Console.Write($"Please enter number of numbers {i} : ");
                inp = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    max = min = inp;
                }
                else
                {
                    if (inp > max)
                    {
                        max = inp;
                    }
                    if (inp < min)
                    {
                        min = inp;
                    }
                }
            }
            Console.WriteLine($"The maximan value is : {max}");
            Console.WriteLine($"The minimum value is : {min}");


            ////////////////////////////////
            //  problem 2  expected output//
            ////////////////////////////////
            int size;
            do
            {
                Console.Write("Please enter the SIZE as ODD number: ");
                size = int.Parse(Console.ReadLine());
            } while (size % 2 == 0);

            print_row_and_column_for_numbers(size);


            ///////////////////////////////////
            //  problem 2  showing the matrex//
            ///////////////////////////////////
            int size;
            do
            {
                Console.Write("Please enter the SIZE as ODD number: ");
                size = int.Parse(Console.ReadLine());
            } while (size % 2 == 0);
            for (int row = 1; row <= size; row++)
            {
                for (int columin = 1; columin <= size; columin++)
                {
                    int curent_position_value = calc_curent_position_value(size, row, columin);
                    Console.Write($"{curent_position_value} ");
                }
                Console.WriteLine();
            }


        }
    }
}
