/// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
/// Display the reversed name on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class ReverseString
    {
        static void reverse()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
        static void Main(string[] args)
        {
            reverse();
        }
    }
}
