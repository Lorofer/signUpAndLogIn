using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    internal class LogIn {
        static public bool DisplayFrom()
        {
            Console.Clear();
            Console.WriteLine("Вход в аккаунт\n");

            Console.WriteLine("Введи логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введи пароль:");
            string password = Console.ReadLine();

            return AccountList.FindAnAccount(login, password);
        }
    }
}