
//Create a class number with 3 integer instance variable x, y and z. The class will have one
//    constructor to initialize instance varilable and method getmax that returns largest number 
//    among three, getprime method that prints prime number from x to y. now create an object of
//    number class and demonstrate the above scenario.

using System;

     class Number
    {
    private int x;
    private int y;
    private int z;

    public Number(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }

    public void getMax()
    {
        if(x>y && x > z)
        {
            Console.WriteLine("The max number is "+ x);
        }

        else if(y>x && y > z){
            Console.WriteLine("The max number is " + y);
        }

        else
        {
            Console.WriteLine("The max number is "+ z);
        }
        
    }



    }

