//create a class having instance variable length and breadth both in double. Now create properties for it and calculate perimeter and area in main method;

using System;


namespace firstproject
{
    class Rectangle
    {
        private int length;
        private int breadth;

        public int Length
        {
            set { length = value; }
            get { return length; }
        }

        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }
    }
}
