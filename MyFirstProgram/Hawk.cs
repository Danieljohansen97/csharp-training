using MyFirstProgram.Interfaces;

namespace MyFirstProgram
{
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }
}