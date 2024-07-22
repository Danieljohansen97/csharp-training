using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Boat : Vehicle
    {
        public int wheels = 0;

        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
