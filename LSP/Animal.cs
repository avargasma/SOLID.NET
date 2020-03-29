using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Animal: IAnimal
    {
        public string Noise { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
}
