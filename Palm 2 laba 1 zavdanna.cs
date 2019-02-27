using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void input(int[,] array)
        {
            string[] input1 = Console.ReadLine().Split();
            int l = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(input1[l]);
                }
            }
        }

        static void Print(int[,] array)
        {
            Console.WriteLine("Введений вами масив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
        }

        static void Sum(int[,] array)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        for (j = 0; j < array.GetLength(1); j++)
                        {
                            sum += array[i, j];
                        }

                        Console.WriteLine("У {0} рядку середнє арифметичне елементів = {1}", i, sum / j);
                        sum = 0;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість рядків матриці");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпчиків матриці");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            Console.WriteLine("Вводьте масив в рядок через пробіл");
            input(array);
            Print(array);
            Console.WriteLine();
            Sum(array);
            Console.ReadKey();
        }

    }
}
