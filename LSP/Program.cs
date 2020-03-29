using LSP.Interface;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanFly animal = new Bird();
            animal.Noise = "Aww";
            animal.MakeNoise();
            animal.Fly();
            Console.ReadLine();
        }
    }
}
