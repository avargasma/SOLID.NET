using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interface;

namespace DIP.Class
{
    public class Employee
    {
        private List<IMessage> _messages;
        public Employee(List<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.sendMessage();
            }
        }
    }
}
