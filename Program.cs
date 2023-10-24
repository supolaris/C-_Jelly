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
            Console.WriteLine("Short hand if Else");

            int myWord = 627;
            int rollNumber = 27;
            //this is called short hand if else
            string answer = (myWord > rollNumber) ? "myword is greater" : "myWord is not greate";
            Console.WriteLine("The answer " + answer);
        }
    }
}
