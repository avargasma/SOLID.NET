using DIP.Class;
using DIP.Interface;
using System;
using System.Collections.Generic;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMessage> messages = new List<IMessage>
            {
                new Email() { idMessage = 1 },
                new Email() { idMessage = 2 },
                new SMS() { idMessage = 3 },
                new Email() { idMessage = 4 },
                new SMS() { idMessage = 5 }
            };

            Employee employee = new Employee(messages);
            employee.Send();
        }
    }
}
