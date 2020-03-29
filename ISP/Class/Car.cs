using ISP.Interface;
using System;

namespace ISP.Class
{
    public class Car : IVehicle, IEngineVehicle
    {
        public int GetNumberOfWheel()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("Move right now");
        }

        public void startEngine()
        {
            Console.WriteLine("Star engine");
        }

        public void stopEngine()
        {
            Console.WriteLine("Stop engine");
        }
    }
}
