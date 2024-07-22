using MyFirstProgram.Interfaces;

namespace MyFirstProgram
{
    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish searches for smaller fish!");
        }
    }
}