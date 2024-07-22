using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    abstract class Vehicle
    {
        public int speed = 0;

        public virtual void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }
}
