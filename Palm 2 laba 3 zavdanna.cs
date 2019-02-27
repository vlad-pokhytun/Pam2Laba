using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    { 
       static void input(int[] first)
        {
           
            Console.WriteLine("Вводьте масив у один рядок через пробіл");
            string[] array = Console.ReadLine().Split();
              for (int i = 0; i < array.Length; i++)
                  {
                      first[i] = int.Parse(array[i]);
                  }
        }

        static void print(int[] second)
        {
            Console.WriteLine("Масив без єлементів з парними індексами:");
            for (int l = 0; l < second.Length; l++)
            {
                Console.Write("{0} ", second[l]);
            }
        }


        static void delete(int[] first)
        {   int[] second = new int[first.Lenght / 2];
            int l = 0;
            for (int i = 0; i < first.Length; i++)
            {

                if (i % 2 != 0)
                {
                    
                    second[l] = first[i];
                    
                    l++;
                }
                else { continue;}
            }

            print(second);
        }
        static void Main(string[] args)
        {
             
             
            Console.WriteLine("Введіть довжину масиву");
             int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
             input(first);
             delete(first);
             Console.ReadKey();
           
           
        }
    }
}
