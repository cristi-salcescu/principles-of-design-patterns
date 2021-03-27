using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class SmsProvider1 : ISmsProvider
    {
        public void SendSms(string from, string to, string message)
        {
            Console.WriteLine("Send SMS Provider 1");
        }
    }
}
