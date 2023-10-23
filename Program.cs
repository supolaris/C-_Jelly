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
            //String input
            Console.WriteLine("Getting input as a string");
            string myWord = Console.ReadLine();
            Console.WriteLine(myWord);

            //Integer input
            Console.WriteLine("Getting input as a integer");
            int myIntNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myIntNum);

            //Float input
            Console.WriteLine("Getting input a a float");
            float myFloatNum = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(myFloatNum);

            Console.ReadKey();
            
        }
    }
}
