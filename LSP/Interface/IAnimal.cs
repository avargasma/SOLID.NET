using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Interface
{
    public interface IAnimal
    {
        string Noise { get; set; }
        void MakeNoise();
    }
}
