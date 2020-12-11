using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_HW.Task3
{
    public class Order : Customer
    {
        public int OrderNumber { get; private set; }

        public Order(string customerName, string customerAddress, string customerEmail) : base(customerName, customerAddress, customerEmail)
        {
            var random = new Random();
            OrderNumber = random.Next(100000, 500000);
        }

        public void GetOrderInformation()
        {
            Console.WriteLine("Order number\t{0}\nCustomer Name\t{1}\nCustomer Address\t{2}\nCustomer Email\t{3}\n",
                OrderNumber, CustomerName, CustomerAddress, CustomerEmail);
        }
    }
}
