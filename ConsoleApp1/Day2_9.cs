using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog
    {
        public void Speak()
        {
            Console.WriteLine("Bark !");
        }
    }
    class class7
    {
        
        static void Main(string[] args)
        {
            Object o = new Dog();
            Dog dog = o as Dog;
            if(dog != null)
            {
                dog.Speak();
            }
            Console.ReadLine();

        }
    }
}
