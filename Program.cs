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
            Console.WriteLine("String Interpolation");
            string firstWord = "hello";
            string secondWord = "World";
            string interpolationWord = $"The combine words is {firstWord} {secondWord}";
            Console.WriteLine(interpolationWord);
        }
    }
}
