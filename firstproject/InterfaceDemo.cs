using System;

//interface is like a abstract class but it containscfbv only list of abstract method.
//multiple inheritance is possible  using interface
//1. Its objective cannot be created
//2. it only contains list of abstract method(no constructor, method, fixed instance variavle
//3. it is used to achieve dynamic polymorphism and multiple inheritance
//4. normal class have to inherit interface and must provide implementation of
//all the method define in interface

     interface Calc1
    {
    //list of abstract method(no body part)
    void calcSum(int x, int y);
    void calcMulti(int x, int y);
    }

interface Calc2
{
    void calcDiv(int x, int y);
}

class InterfaceDemo : Calc1, Calc2
{
    public void calcSum(int x, int y)
    {
        Console.WriteLine("Sum is " +(x + y));
    }

    public void calcMulti(int x, int y)
    {
        Console.WriteLine("Multi is " + (x * y));
    }

    public void calcDiv(int x, int y)
    {
        Console.WriteLine("DIv is " + (x/y));
    }

}





