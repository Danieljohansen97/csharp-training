using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Rocket
    {
        private int speed;

        public Rocket(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; } //read
            set
            {
                if( value > 250 )
                {
                    speed = 250;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
