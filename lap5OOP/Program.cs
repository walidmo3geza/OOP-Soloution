using System;

namespace lap5OOP
{
    internal class Program
    {
        public static void calc_index_of_max_and_min(int[] a, ref int index_of_max, ref int index_of_min)
        {
            int max, min;
            max = min = a[0];
            index_of_max = 0;
            index_of_min = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    index_of_min = i;
                }
                if (a[i] > max)
                {
                    max = a[i];
                    index_of_max = i;
                }
            }
        }
        public static void calc_total_and_avg(float[,] grades, float[] calculated_total, float[] calculated_avg)
        {
            for(int i = 0; i < 3; i++)
            {
                float total = 0;
                for(int j=0;j< 3; j++)
                {
                    total += grades[i, j];
                }
                calculated_total[i] = total;
            }
            for (int i = 0; i < 3; i++)
            {
                float total = 0;
                for (int j = 0; j < 3; j++)
                {
                    total += grades[j, i];
                }
                calculated_avg[i] = total / 3;
            }
        }
        public static void calc_total_grades_foeach_student(float[][] grades, float[] total)
        {
            for(int i = 0; i < 3; i++)
            {
                float sum = 0;
                for(int j = 0; j < grades[i].Length; j++)
                {
                    sum += grades[i][j];
                }
                total[i] = sum;
            }
        }
        static void Main(string[] args)
        {
            int inp;
            
            do
            {
                Console.WriteLine("Please inter ");
                Console.WriteLine("1 to check task nomber 1");
                Console.WriteLine("2 to check task nomber 2");
                Console.WriteLine("3 to check task nomber 3");
                inp = int.Parse(Console.ReadLine());
                if(inp == 1)
                {
                    int[] a = new int[5];
                    int max_position = -1, min_position = -1;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Please enter number{i + 1}");
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    calc_index_of_max_and_min(a, ref max_position, ref min_position);
                    Console.WriteLine($"The index of the maximum value is {max_position}");
                    Console.WriteLine($"The index of the minimum value is {min_position}");
                }
                else if (inp == 2)
                {
                    float[,] grades = { { 1.5f, 2.3f, 3.3f }, { 4f, 5f, 6.2f }, { 7, 8.2f, 9 } };
                    float[] total_grades_for_each_student = new float[3];
                    float[] average_for_each_subject = new float[3];
                    calc_total_and_avg(grades, total_grades_for_each_student, average_for_each_subject);
                    for(int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"The total of grages of student number {i + 1} = {total_grades_for_each_student[i]}");
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"The average of grages of subject number {i + 1} = {average_for_each_subject[i]}");
                    }
                }
                else if (inp == 3)
                {
                    float[][] grades_of_each_students = new float[3][];
                    for(int i = 0; i < 3; i++)
                    {
                        Console.Write($"Please enter number of subjects that student number {i + 1} have : ");
                        int number_of_subjects = int.Parse(Console.ReadLine());
                        grades_of_each_students[i] = new float[number_of_subjects];
                        for(int j=0; j < number_of_subjects; j++)
                        {
                            Console.Write($"enter grade of subject number {j + 1} that student number {i + 1} take : ");
                            grades_of_each_students[i][j] = float.Parse(Console.ReadLine());
                        }
                    }
                    float[] result = new float[3];
                    calc_total_grades_foeach_student(grades_of_each_students, result);
                    for(int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"The total grades of student number {i} = {result[i]}");
                    }
                }
            } while (inp != 1 && inp != 2 && inp != 3);
        }
    }
}
