using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircleObjects
{
    internal class Circle
    {
        //private property
        private double radius = -1;

        public double CircleRadius { get; set; }


        //Constructor
        public Circle(double radius)
        {
            CircleRadius = radius;
        }

        //Calculate Diameter
        public double CalculateDiameter(double radius)
        {
            return radius * 2;
        }

        //Calculate Circumference
        public double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        // Calculate Area
        public double CalculateArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        public double Grow(double input)
        {
            return input * 2;
        }


    }

}

