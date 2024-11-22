using System;




    class Ageerror : Exception
{
    public Ageerror(string msg):base(msg) {
    }
}




    class CustomException
    {
    public void sendAge(int age)
    {
        if(age <18 )
        {
            throw new Ageerror("age must be greater than 18");
        }
        else
        {
            Console.WriteLine("Welcome");
        }
    }
    }

