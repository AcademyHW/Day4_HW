using System.Text.RegularExpressions;
using System;

namespace Day4_HW.Task3
{
    public class Customer
    {
        public string customerName { get; private set; }
        public string customerAddress { get; private set; }
        public string customerEmail { get; private set; }

        public Customer(string name, string address, string email)
        {
            customerName = name;
            customerAddress = address;
            UpdateEmail(email);
        }

        public void UpdateEmail(string email)
        {
            if (CheckEmail(email))
            {
                customerEmail = email;
            }
            else
            {
                System.Console.WriteLine("Please retry email input: ");
                UpdateEmail(Console.ReadLine());
            }
        }

        private bool CheckEmail(string Email)
        {
            string Pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(Email, Pattern);
        }
    }
}
