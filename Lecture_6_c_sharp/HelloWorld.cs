using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_6_c_sharp
{
    class HelloWorld
    {
        public static void one()
        {
            var age = 25;
            Console.WriteLine("var holds Type:{0} | VAL:{1}" + age.GetType() + age);
            var name = "Lauryne";
            Console.WriteLine("var holds TYPE:{0} | VAL:{1}" + name.GetType() + name);

        }

        public static void two()
        {
            int[] odds = new[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("var holds an array of numbers");
            foreach (var num in odds)
            {
                Console.WriteLine("TYPE:{0}|VAL:{1}" + num.GetType() + num);
            }
        }
        public static void three()
        {
            var p1 = new Person();
            //p1.FirstName = "";

        }

    }
}
