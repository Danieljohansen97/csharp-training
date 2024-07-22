using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}
