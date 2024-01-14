using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    internal class SomeApp {
        public static void DisplayApp()
        {
            Console.WriteLine("Вы вошли в аккаунт!\n");
            Console.WriteLine("log out - выйти");

            while (true) {
                switch (Console.ReadLine()) {
                    case ("log out"):
                        return;

                    default:
                        Console.WriteLine("Допущена опечатка! Повторите ввод!");
                        break;
                }
            }
        }
    }
}
