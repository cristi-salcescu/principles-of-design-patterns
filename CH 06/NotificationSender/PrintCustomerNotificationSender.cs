using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class PrintCustomerNotificationSender : ICustomerNotificationSender
    {
        byte[] CreatePDF(Customer customer)
        {
            return new byte[0];
        }

        void SaveFile(byte[] content)
        {
            Console.WriteLine("Save PDF file");
        }

        public void SendMessage(Customer customer)
        {
            var content = CreatePDF(customer);
            SaveFile(content);
        }
    }
}
