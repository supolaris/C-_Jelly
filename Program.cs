using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Jelly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value from an Array");
            int[,] myAray = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine(myAray[i,j]);    
                }
            }

        }
    }
}
