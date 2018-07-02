using System;

namespace hello_world
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] animals = {"dogs", "cat", "bird", "bear", "horse"};
            foreach (string animal in animals)
           {
               Console.WriteLine(animal)
           }
        }
    }
}
