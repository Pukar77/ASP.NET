using System;


//use of base keyword
//1. method overriding
//2. to call superclass constructor

namespace firstproject
{
    class Calculation
    {
        private int x1;
        private int y1;


        //default constructor of parent
        public Calculation()
        {
            Console.WriteLine("This is deafult constructor of super class");
        }

        //parameterized constructor
        public Calculation(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public void calcSum()
        {
            Console.WriteLine("Sum is "+ (x1 + y1));
        }

    }

    //child class
    class Solution: Calculation
    {
        private int x2;
        private int y2;

        //default constructor of child class
        public Solution()
        {
            Console.WriteLine("Default constructor of child");
        }

        //parameterized constructor
        public Solution(int x2, int y2, int x1, int y1):base(x1,y1)
        {
            this.x2 = x2;   
            this.y2 = y2;
        }

        public void calcDiff()
        {
            Console.WriteLine("Difference is "+ (x2-y2));
        }
    }
}
