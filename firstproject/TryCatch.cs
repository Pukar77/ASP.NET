using System;


namespace firstproject
{
    class TryCatch
    {
        //taking input from user and dividing by zero
        public void setData()
        {
            Console.WriteLine("Enter first number");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y1 = Int32.Parse(Console.ReadLine());
            try
            {
                int res = x1 / y1;  //if y1 = 0 then error occur
                Console.WriteLine("Div is " + res);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Denominator should not be zero" + d);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured" + e);
            }
            finally
            {
                Console.WriteLine("Out of try catch block");
            }



        }
    }
}
