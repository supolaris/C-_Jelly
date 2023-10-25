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

            Console.WriteLine("Enter Your First Name");
            string myFirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            string myLastName = Console.ReadLine();
            Console.WriteLine("Enter Your Street Address");
            string myStreetAddress = Console.ReadLine();
            Console.WriteLine("Enter your bill amount");
            int myBill = Convert.ToInt32(Console.ReadLine());
            int myMaxBill = 1000;
            int myMinBill = 10000;

            if (myBill >= myMaxBill)
            {
                Console.WriteLine("Message here");
                myBill += 500;

            }
            else if(myBill < myMaxBill) {
                myBill += 50;
            }
            else if(myBill == myMinBill) {
                myBill += 250;
            }

            Console.WriteLine("Your Electricity Bill");
            Console.WriteLine("---------------------");
            Console.WriteLine("First Name: " + myFirstName);
            Console.WriteLine("Last Name: " + myLastName);
            Console.WriteLine("Your Bill is " + myBill);

        }
    }
}
