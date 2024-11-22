using System;

namespace firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box b1 = new Box();
            //b1.Length = 30;
            //int len = b1.Length;
            //b1.Breadth = 20;
            //int bre = b1.Breadth;
            //b1.Height = 10;
            //int hei = b1.Height;

            //int vol = len * bre * hei;
            //Console.WriteLine(vol);




            //Classwork 1

            //Rectangle r1 = new Rectangle();
            //r1.Length = 10;
            //int len = r1.Length;

            //r1.Breadth = 20;
            //int bre = r1.Breadth;

            //int area = len * bre;

            //Console.WriteLine(area);


            //example on inheritance

            //create object of child always

            //Student s1 = new Student();
            //s1.setStd("Science", "A+");

            //s1.displayStudent();
            //s1.setPerson(20, "pukar", "balaju");
            //s1.displayPerson();

            //Primarystudent p1 = new Primarystudent();

            //p1.setps("20");
            //p1.displayTime();
            //p1.setStd("kindergarden","C+");
            //p1.displayStudent();
            //p1.setPerson(20, "rimal", "hero");
            //p1.displayPerson();

            //Car c1 = new Car();
            //c1.setVechile(200, "audi", "maruti");
            //Car c2 = new Car();
            //c2.setVechile(300, "alto", "suzuki");

            //c1.setCar(20);
            //c2.setCar(30);
            //c2.displayVechile();

            //examle of basekeyword

            //Solution s1 = new Solution();
            //Solution s2 = new Solution(3,5, 10,20);

            //s2.calcSum();
            //s2.calcDiff();

            ////method overriding
            //Answer a1 = new Answer();
            //a1.Calc1();
            //a1.Calc2(10,20);


            //    abstract class
            //    Ans1 an1 = new Ans1(40, 50);
            //an1.displaySum();  //abstract method ko normal method
            //    an1.DisplayDiv();
            //    an1.displayMulti(2,2);
            //    an1.displayDiff(3,1);


            //try catch
            //TryCatch t1 = new TryCatch();
            //t1.setData();

            ////customexception
            //CustomException ex = new CustomException();
            //try
            //{
            //    ex.sendAge(11);
            //}
            //catch(Ageerror a)
            //{
            //    Console.WriteLine(a);
            //}


            ////question
            //Number n1 = new Number(4,8,7);
            //n1.getMax();
            //

            //question1
            //Box1 b1 = new Box1();


            //interfaceDemo
            InterfaceDemo demo = new InterfaceDemo();
            demo.calcSum(2, 3);
            demo.calcMulti(2 , 3);
            demo.calcDiv(8, 4);

            //dynamic method dispatch: when subclass's object is assigned to reference
            //variable of superclass then such reference will call the subclass version
            //of overridden method

            Calc1 c;
            c = demo;
            c.calcSum(20, 30);
            c.calcMulti(20, 30);





           
           






        }
    }
}


