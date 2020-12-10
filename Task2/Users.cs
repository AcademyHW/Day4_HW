using System;
using System.Security.Cryptography;
using System.Text;

namespace Day4_HW.Task2
{
    static class Users
    {
        public struct User
        {
            private byte[] _Password;

            public string Login { get; set; }
            public string Password 
            { 
                set
                {
                    var md5 = new MD5CryptoServiceProvider();
                    _Password = md5.ComputeHash(Encoding.UTF8.GetBytes(value)); //infSec
                }
                get
                {
                    if (_Password!=null)
                    {
                        return BitConverter.ToString(_Password);
                    }
                    else
                    {
                        return "Password invalid";
                    }
                }
            }
        }

        public static void CheckAuth(User[] dataBase, string login, string password)
        {
            var exist = false;
            var md5 = new MD5CryptoServiceProvider();
            password = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(password)));
            foreach (var user in dataBase)
            {
                if (user.Login == login)
                {
                    exist = true;
                }
                if (user.Login == login && user.Password == password)
                {
                    Console.WriteLine("Password for {0} is correct!", login);
                }
                if (user.Login == login && user.Password != password)
                {
                    Console.WriteLine("Password for {0} dont correct!", login);
                }
            }
            if (!exist)
            {
                Console.WriteLine("User dont exist!");
            }
        }

        public static User[] CreateDataBase()
        {
            var dataBase = new User[10];
            for (int i = 0; i < 10; i++)
            {
                dataBase[i] = new User();
                dataBase[i].Login = $"User{i}";
                dataBase[i].Password = $"pass{i}";
            }
            return dataBase;
        }
    }
}
