using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interface
{
   public  interface IMessage
    {
        int idMessage { get; set; }
        void sendMessage();
    }
}
