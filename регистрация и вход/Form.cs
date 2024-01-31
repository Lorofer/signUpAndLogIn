using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUpAndLogIn {
    internal class Form {
        static public string login;
        static public string password;
        static public void DisplaySingUpForm()
        {
            Console.Clear();
            Console.WriteLine("Регистрация\n");

            Console.WriteLine("Придумай логин:");
            login = Console.ReadLine();

            Console.WriteLine("Придумай пароль:");
            password = Console.ReadLine();
        }

        static public void DisplayLogInForm()
        {
            Console.Clear();
            Console.WriteLine("Регистрация\n");

            Console.WriteLine("Введи логин:");
            login = Console.ReadLine();

            Console.WriteLine("Введи пароль:");
            password = Console.ReadLine();
        }
    }
}