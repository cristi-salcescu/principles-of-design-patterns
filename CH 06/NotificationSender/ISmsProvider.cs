using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public interface ISmsProvider
    {
        void SendSms(string from, string to, string message);
    }
}
