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
            Console.WriteLine("If Else Statements");
            int myNum = 20;
            if(myNum == 0 || myNum >2)
            {
                if(myNum == 20)
                {
                    Console.WriteLine("the value is 20");
                }

            }
            else if(myNum == 1)
            {
                Console.WriteLine("value is not met in else if condition");
            }
            else
            {
                Console.WriteLine("the value is another");
            }
            Console.ReadKey();
        }
    }
}
