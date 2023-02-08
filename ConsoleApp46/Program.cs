using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("n=");
            byte n = Convert.ToByte(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-20, 20);
                WriteLine($"array[{i}] = {array[i]}");
            }
            byte count = 0;
            /* for (int i = 0; i<array.Length; i++)
             {
                 if (array[i] < 0) count++;
             }
             WriteLine($"кол-во отриц. элементов ={count}");*/
            foreach (int num in array)
            {
                if (num < 0) count++;

            }
            WriteLine($"кол-во отриц чисел = {count}");
            ReadKey();
        }
        
    }
}
