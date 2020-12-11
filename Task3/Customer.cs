using System.Text.RegularExpressions;
using System;

namespace Day4_HW.Task3
{
    public class Customer
    {
        public string CustomerName { get; private set; }
        public string CustomerAddress { get; private set; }
        public string CustomerEmail { get; private set; }

        public Customer(string name, string address, string email)
        {
            CustomerName = name;
            CustomerAddress = address;
            UpdateEmail(email);
        }

        public void UpdateEmail(string email)
        {
            if (CheckEmail(email))
            {
                CustomerEmail = email;
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
