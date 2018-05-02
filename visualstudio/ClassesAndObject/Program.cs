using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObject
{
 
    class Dog
    {
        public string name;
        public int size;
        public string breed;
        public ConsoleColor color;

        public void Walk()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " is walking.");
        }
        public void Eat(String food)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name +  " is eating " + food);
        }
        public void Shit()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " is shitting");
        }
        public void Sleep()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " is sleeping.");
        }
        public void Wag()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " tail swipe.");
        }
        public void Speak()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " i'm gay!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
          

            Dog dog1 = new Dog();
            dog1.name = "Pink Guy";
            dog1.size = 5;
            dog1.breed = "Cavoodle";
            dog1.color = ConsoleColor.Magenta;

            dog1.Speak();
            dog1.Walk();
            dog1.Eat("Raw reman");
            dog1.Shit();

            Console.ReadLine();
       
            Dog dog2 = new Dog();
            dog1.name = "YUS";
            dog1.size = 5;
            dog1.breed = "Cavoodle";
            dog1.color = ConsoleColor.Yellow;

            dog1.Speak();
            dog1.Walk();
            dog1.Eat("Raw reman");
            dog1.Shit();

            Console.ReadLine();


        }
    }
}
