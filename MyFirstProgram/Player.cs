using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Player
    {
        public String username;

        public Player(String username) 
        { 
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
