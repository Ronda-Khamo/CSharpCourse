using System;

namespace ModulusExample
{
    class ModHandler
    {
        public void ComputeModulus(int number, int id)
        {
            int mod = number % 7; // Find the remainder when divided by 7
            Console.WriteLine("Remainder of number % 7: " + mod);
            Console.WriteLine("ID received: " + id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ModHandler mh = new ModHandler(); // Create an object

            mh.ComputeModulus(50, 123); // Positional args

            mh.ComputeModulus(id: 777, number: 29); // Named args

            Console.ReadLine(); // Pause console
        }
    }
}
