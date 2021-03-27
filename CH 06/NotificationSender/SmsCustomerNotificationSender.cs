using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class SmsCustomerNotificationSender : ICustomerNotificationSender
    {
        private ISmsProvider smsProvider;

        public SmsCustomerNotificationSender(ISmsProvider smsProvider)
        {
            this.smsProvider = smsProvider;
        }

        string CreateMessage(Customer customer)
        {
            return $"Sms message to {customer.Phone}";
        }

        void SendSms(string to, string message)
        {
            this.smsProvider.SendSms("000-000-000", to, message);
        }

        public void SendMessage(Customer customer)
        {
            var message = CreateMessage(customer);
            SendSms(customer.Phone, message);
        }
    }
}
