using ISP.Class;
using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Console.WriteLine("Carro");
            Console.WriteLine("Number of wheels " + car.GetNumberOfWheel().ToString());
            car.startEngine();
            car.Move();
            car.stopEngine();

            Console.WriteLine("Bicicleta");
            Console.WriteLine("Number of wheels " + bicycle.GetNumberOfWheel().ToString());
            bicycle.Move();
        }
    }
}
