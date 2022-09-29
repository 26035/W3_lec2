using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_6_c_sharp
{
    interface IPolygon
    {
        string Name
        {
            get;
            set;
        }
        int NumOfSides
        {
            get;
            //private set; // Will Not Work
        }
        void calculateArea(params int[] sides);

    }
    
}
