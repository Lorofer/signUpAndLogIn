using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    class AddAccount {
        static public void DisplayFrom()
        {
            Console.Clear();
            Console.WriteLine("Регистрация\n");

            Console.WriteLine("Придумай логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Придумай пароль:");
            string password = Console.ReadLine();

            AccountList.AddAccount(login, password);
        }
    }
}