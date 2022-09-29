using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_6_c_sharp
{
    class Rectangle : IPolygon, IColor
    {
        //implementation of IPolygon interface
        private string _name;
        public string Name // read-write instance property
        {
            get => _name;
            set => _name = value;

        }
        private int _numOfSides;
        public int NumOfSides // read-only instance property
        {
            get => _numOfSides;
            private set => _numOfSides = value;

        }
        public void calculateArea(int[] sides)
        {
            int area = sides[0] * sides[1];
            Console.WriteLine("Area of Rectangle" + area);

        }
        // implementation of IColor interface
        public void getColor()
        {
            Console.WriteLine("Red Rectangle");

        }
        public Rectangle() => _numOfSides = 4;

    }
}
