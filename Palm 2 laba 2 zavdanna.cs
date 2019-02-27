using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void input(int[,] array)
        {
            Console.WriteLine("Вводьте масив у один рядок через пробіл");
            string[] input1 = Console.ReadLine().Split();
            int l = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++, l++)
                {
                    array[i, j] = int.Parse(input1[l]);
                }
            }
        }

        static void Print(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
        }

        static void Zmichenna(int[,] array)
        {
            int f = 0;
            int l = array.GetLength(0) - 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int temp = array[f, 0];
                    array[f, 0] = array[l, f];
                    array[l, f] = temp;
                }
                f++;
                l--;

            }
            Console.WriteLine();
            Console.WriteLine("Перетворений масив :");
            Print(array);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість рядків масиву");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпчиків масиву");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            input(array);
            Console.WriteLine("Введений вами масив:");
            Print(array);
            Zmichenna(array);


            Console.ReadKey();
        }
    }
}
