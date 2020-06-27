/*
Write a program and ask the user to enter the width and height of an image. 
Then tell if the image is landscape or portrait.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }
    class Orientation
    {
        static void orientation()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }
        static void Main(string[] args)
        {
            orientation();
        }
    }
}
