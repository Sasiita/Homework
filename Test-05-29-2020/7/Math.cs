using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Math
    {
        private double diameter;
        private double rectangleA;
        private double rectangleB;
        private double cubeA;

        public Math(double diameter, double rectangleA, double rectangleB, double cubeA)
        {
            this.diameter = diameter;
            this.rectangleA = rectangleA;
            this.rectangleB = rectangleB;
            this.cubeA = cubeA;
        }
             
        public double FaceOfCircle
        {
            get { return (System.Math.PI * System.Math.Pow(this.diameter / 2, 2)); }
        }

        public double FaceOfRectangle
        {
            get { return this.rectangleA * this.rectangleB; }
        }

        public double FaceOfCube
        {
            get { return this.cubeA * this.cubeA; }
        }
    }
}
