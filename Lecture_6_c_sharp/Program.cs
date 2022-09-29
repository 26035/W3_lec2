using System;

namespace Lecture_6_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Name = "rectangle_1";
            r1.calculateArea(new int[] { 100, 200 });
            r1.getColor();

            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";
            t1.calculateArea(new int[] { 100, 200,300 });
            r1.getColor();

        }
    }
}
