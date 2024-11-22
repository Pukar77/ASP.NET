using System;

//such class whose object cannot be created and declared using abstract keyword. It is used to hide complex detail of class its object cannot be created
//It can have instance variable, method and coonstructor
//it can have abstract method: such method which is declared only but not initialize
//normal class should inherit abstract class and such normal class have to provide body part of all the abstract method



namespace firstproject
{
    abstract class Question
    {
        //it can have instanace variable
        private int x1;
        private int y1;
        //it can have constructor

        public Question(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;   
        }

        //normal method
        public void displaySum()
        {
            Console.WriteLine("sum is " + (x1 + y1));
        }

        //extra: it can have abstract method
        //abstract method donot have body part
        public abstract void displayDiff(int x, int y);
        public abstract void displayMulti(int x, int y);

    }

    //abstract class should be used by normal class
    class Ans1 : Question
    {
        private int x;
        private int y;

        public Ans1(int x, int y):base(x,y)
        {
            this.x = x;
            this.y = y;

        }

        //normal method

        public void DisplayDiv()
        {
            Console.WriteLine("Div is " + (x / y));
        }

        public  override void displayDiff(int x, int y)
        {
            Console.WriteLine("DIff is " + (x - y));
        }
        public override void displayMulti(int x, int y)
        {
            Console.WriteLine("multi  is " + (x * y));

        }
    }
}
