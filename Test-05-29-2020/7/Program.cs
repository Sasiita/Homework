using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double diameter = Input("Enter diameter of the circle: ");
            double rectangleA = Input("First side of rectangle: ");
            double rectangleB = Input("Second side of rectangle: ");
            double cubeA = Input("Side of cube: ");
            var math = new Math(diameter, rectangleA, rectangleB, cubeA);

            Console.WriteLine("Face of circle: " + math.FaceOfCircle);
            Console.WriteLine("Face of rectangle: " + math.FaceOfRectangle);
            Console.WriteLine("Face of cube: " + math.FaceOfCube);
            Console.ReadLine();
        }

        static double Input(string text)
        {
            Console.Write(text);
            return double.Parse(Console.ReadLine());
        }
    }
}
