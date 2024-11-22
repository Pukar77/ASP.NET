using System;

//method overriding is a condition in which super class and sub class has same method with same signature(same name, same return type, same parameter)
//two keyword are used in method overriding:  
//1) Virtual key word used to denote overriden method of superclass
//2) override keyword: used to denote overriden method of sub class
//when overriden method is called from sub class object then subclass version of overriden method is called so to call super class version of overriden  method base keyword should be used
//method overriding is used to achieve dynakmic polymorphism


namespace firstproject
{
     class Solve
    {
        public virtual void  Calc1()
        {
            Console.WriteLine("Default method of superclass");
        }
        public virtual void Calc2(int x, int y)
        {
            Console.WriteLine("sum is " + (x + y));
        }
    }

    class Answer : Solve
    {
        public override void Calc1()
        {
            base.Calc1();
            Console.WriteLine("Default method of subclass");
        }

        public override void Calc2(int x, int y)
        {
            base.Calc2(x,y);
            Console.WriteLine("Diff is " + (x - y));
        } 


    }
}
