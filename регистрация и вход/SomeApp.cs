using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUpAndLogIn {
    internal class SomeApp {
        public static bool DisplayApp()
        {
            Console.Clear();
            Console.WriteLine("Вы вошли в аккаунт!\n");

            Console.WriteLine("log out\t- выйти из аккаунта\n" +
                "exit\t- закрыть программу");

            while (true) {
                switch (Console.ReadLine()) {
                    case ("log out"):
                        return true;

                    case ("exit"):
                        return false;

                    default:
                        Console.WriteLine("Допущена опечатка! Повторите ввод!");
                        break;
                }
            }
        }
    }
}