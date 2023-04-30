using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Implemented
{
    //derived class
    public class Rectangle : Shape
    {
        public int GetArea()
        {
            return width * height;
        }
    }
}
