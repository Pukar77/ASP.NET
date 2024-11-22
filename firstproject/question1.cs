using System;





     class Box1
    {
        private int length;
        private int breadth;
        private int height;


        public Box1(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
            
        }

        public void getVol()
        {
            Console.WriteLine("The voulume of the box is " + (length * breadth * height));
        }

    }


   


