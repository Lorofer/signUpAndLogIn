using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    internal class AccountList {
        static private List<Account> accounts = new List<Account>();
        static public void AddAccount()
        {
            Console.WriteLine("Придумай логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Придумай пароль:");
            string password = Console.ReadLine();

            Account newAccount = new Account { Login = login, Password = password };
            accounts.Add(newAccount);
        }
        static public void LogIn()
        {
            while (true) {
                Console.WriteLine("Введи логин:");
                string enterLog = Console.ReadLine();

                Console.WriteLine("Введи пароль:");
                string enterPass = Console.ReadLine();

                foreach (Account account in accounts) {
                    if (account.Login == enterLog && account.Password == enterPass) {
                        SomeApp.DisplayApp();
                        return;
                    }
                }
                Console.WriteLine("Неверный логин или пароль!");
            } 
        }
    }
}
