
using System;



namespace firstproject
{
     class Vechile
    {
        private int reg;
        private string name;
        private string brand;

       

        public void setVechile(int reg, string name, string brand)
        {
            this.reg = reg;
            this.name = name;
            this.brand = brand;

        }

        public void displayVechile()
        {
            Console.WriteLine("Vechile is registred as " + reg + "and the name is " + name + "and the brand is " + brand);
        }
    }


     class Car : Vechile 
    {
        private int milage;

        public void setCar(int milage)
        {
            this.milage = milage;
        }

        public void displayCar()
        {
            Console.WriteLine("The milage of the car is " + milage);
        }

    }
    
}
