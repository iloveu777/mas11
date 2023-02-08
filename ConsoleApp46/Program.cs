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
            int[] massive = new int[8];
            Random rnd = new Random();
            int i;
            for(i=0; i<massive.Length; i++)
            {
                massive[i] = rnd.Next(-10, 11);
            }

        }
    }
}
