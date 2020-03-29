using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Class
{
    public class SMS : IMessage
    {
        public int idMessage { get; set; }
        public void sendMessage()
        {
            Console.WriteLine("Send message from SMS Id " + idMessage.ToString());
        }
    }
}
