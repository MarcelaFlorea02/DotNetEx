using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Implemented
{
    //base class
    public class Shape
    {
        //visible to any derived class 
        protected int width; 
        protected int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHight(int h)
        {
            height = h; 
        }
    }
}
