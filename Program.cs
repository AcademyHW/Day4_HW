using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            var fruits = new List<Task1.Product>()
            {
                new Task1.Product("Banana","Yellow fruit", 10),
                new Task1.Product("Apple", "Green fruit", 30)
            };
            Console.WriteLine("Fruit {0} is more {1}$ more expensive than {2}",
                fruits.Max().Name,
                fruits.Max().Price - fruits.Min().Price,
                fruits.Min().Name
                );

            Console.WriteLine("Task 2");
            var dataBase = Task2.Users.CreateDataBase();
            Task2.Users.CheckAuth(dataBase, "User1", "pass1");
            Task2.Users.CheckAuth(dataBase, "User2", "passqwe");

            Console.WriteLine("Task 3");
            var order1 = new Task3.Order("Roman", "Ufa, Lenina 123", "roma.yagafarov@gmail.com");
            order1.GetOrderInformation();
        }
    }
}
