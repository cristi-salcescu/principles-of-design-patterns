using System;

namespace NotificationSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                SurName = "Customer",
                FirstName = "Cristian",
                Email = "cristian@email.com",
                Phone = "000-111-222"
            };

            var smsProvider = new SmsProvider1();
            var notificationSender = new SmsCustomerNotificationSender(smsProvider);
            notificationSender.SendMessage(customer);

            Console.ReadKey();
        }
    }
}
