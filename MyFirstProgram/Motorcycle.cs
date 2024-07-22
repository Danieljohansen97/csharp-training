using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Motorcycle : Vehicle
    {
        public int wheels = 2;

        public override void Go()
        {
            Console.WriteLine("The motorcycle is moving!");
        }
    }
}
