using ISP.Interface;
using System;

namespace ISP.Class
{
    public class Bicycle : IVehicle
    {
        public int GetNumberOfWheel()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("Move right now");
        }
    }
}
