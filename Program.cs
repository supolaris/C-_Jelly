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
            Console.WriteLine("Accessing String");

            string myWord = "HelloWorld";
            Console.WriteLine(myWord.Length);

            int indexWord = myWord.IndexOf("r");

            string updatedWord = myWord.Substring(indexWord);
            Console.WriteLine("The updated word is: " + updatedWord);
            Console.ReadKey();

        }
    }
}
