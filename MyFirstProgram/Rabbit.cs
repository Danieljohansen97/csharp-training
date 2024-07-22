using MyFirstProgram.Interfaces;

namespace MyFirstProgram
{
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
}