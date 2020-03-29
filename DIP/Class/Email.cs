using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Class
{
    public class Email : IMessage
    {
        public int idMessage { get; set; }

        public void sendMessage()
        {
            Console.WriteLine("Send message from email Id " + idMessage.ToString());
        }
    }
}
