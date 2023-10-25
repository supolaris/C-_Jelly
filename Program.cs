using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Jelly
{
    internal class Program
    {
        private static object toint32;

        static void Main(string[] args)
        {
            Console.WriteLine("Billing Program using switches");

            Console.WriteLine("Enter Your name");
            string myName = Console.ReadLine();
            Console.WriteLine("Enter your bill amount");
            int myBill = Convert.ToInt32(Console.ReadLine());
            int myMaxValue = 1000;
            int myMinValue = 10000;

            if (myBill >= myMaxValue)
            {
                Console.WriteLine("Message here");
                myBill += 200*1000/myBill;
                Console.WriteLine(myBill);
            }
        }
    }
}
