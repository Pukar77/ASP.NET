using System;


namespace firstproject
{
    //properties:used to set and return the value of instance variable
    //it is like geter and seter method
    class Box
    {
        //instance variable
        private int length;
        private int breadth;
        private int height;

        //setting the value of this instance variable using properties method

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

        public int Height
        {
            set { height = value; }
            get { return height; }
        }
    }
}
