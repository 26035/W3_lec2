using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lecture_6_c_sharp
{
    class Triangle : IPolygon, IColor
    {
        // implementation of IPolygon interface
        private string _name;
        public string Name // read-write instance property
        {
            get => _name;
            set => _name = value;

        }
        private int _numOfSides;
        public int  NumOfSides // read-only instance property
        {
            get => _numOfSides;
            private set => _numOfSides = value;

        }
        public void calculateArea(int[]sides)
        {
            var s = (sides[0] + sides[1] + sides[2]) / 2;
            double area = Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            Console.WriteLine("Area of " + area);

        }
        //implementation
        public void getColor()
        {
            Console.Write("green triangle");

        }

        public Triangle() => _numOfSides = 3;
    }
}
