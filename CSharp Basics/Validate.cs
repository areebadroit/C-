/*
Write a program and ask the user to enter a number. The number should be between 1 to 10. 
If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Validate
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
