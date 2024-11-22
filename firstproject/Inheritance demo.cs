using System;
using System.Globalization;
//inheritance is the process of inheriting properties of one class by another, such claqss that inheritice another class is sub class ro sub class and sunch class that gets inherited by other is super class also known as parent or base

//sub class can use all the properties of super class except private variable and constructor



//type
//1. single level: One parewnt class is inherited by one or more child
//2. multi level : second class inherit first class and such second class inturns gets inherited by third class(grandparent-parent-child relation)
//3. Multiple : Here one child can inherit multiple parent class which is not possible using class but possible using interface



namespace firstproject
{
   
        //parent class
        class Person
        {
            private int age;
            private string name;
            private string address;

            //method to set instance variable
            public void setPerson(int age, string name, string address)
            {
                this.age = age;
                this.name = name;
                this.address = address;

            }
            public void displayPerson()
            {
                Console.WriteLine("age is " + age + "name is " + name + "address is" + address);
            }
        }

        //child class: derived or sub class
        //to inheite a class, : symboli is used
        class Student : Person
        {
            private string faculty;
            private string grade;

            //method
            public void setStd(string faculty, string grade)
            {
                this.faculty = faculty;
                this.grade = grade;
            }


            public void displayStudent() {
                Console.WriteLine("faculty is " + faculty + "grade is " + grade);
            }
        }

    class Primarystudent: Student
    {
        private string time;
        //method
         
        public void setps(string time)
        {
            this.time = time;

        }

        public void displayTime()
        {
            Console.WriteLine("The time of sleep is " + time);
        }

    }
    }

