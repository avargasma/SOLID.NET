using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly..");
        }
    }
}
