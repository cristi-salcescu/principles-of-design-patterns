using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class EmailCustomerNotificationSender : ICustomerNotificationSender
    {
        string CreateMessage(Customer customer)
        {
            return $"Email message to {customer.Email}";
        }

        void SendEmail(string to, string message)
        {
            Console.WriteLine("Send email");
        }

        public void SendMessage(Customer customer)
        {
            var message = CreateMessage(customer);
            SendEmail(customer.Email, message);
        }
    }
}
