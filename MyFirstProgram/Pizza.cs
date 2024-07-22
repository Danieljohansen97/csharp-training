using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        // OVERLOADED CONSTRUCTORS
        // Only bread...
        public Pizza(String bread)
        {
            this.bread = bread;
        }
        // Constructor without cheese and topping
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        // Constructor without topping
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        // A proper pizza
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}
