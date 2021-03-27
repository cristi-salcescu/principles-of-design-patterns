using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    interface ICustomerNotificationSender
    {
        void SendMessage(Customer custormer);
    }
}
