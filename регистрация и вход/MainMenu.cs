using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    internal class MainMenu {
        static public bool DisplayMenu(bool marker = false)
        {
            while (!marker) {
                Console.WriteLine("Главное меню\n");

                Console.WriteLine("Выберите режим:\n" +
                    "sign up\t- зарегистрироваться\n" +
                    "log in\t- войти\n" +
                    "exit\t- завершить работу\n");

                switch (Console.ReadLine()) {
                    case ("sign up"):
                        AddAccount.DisplayFrom();
                        Console.Clear();
                        break;

                    case ("log in"):
                        marker = LogIn.DisplayFrom();
                        if (!marker)
                            Console.WriteLine("Неверный логин или пароль!");
                        break;

                    case ("exit"):
                        Console.Clear();
                        return false;

                    default:
                        Console.Clear();
                        Console.WriteLine("Допущена ошибка! Повторите ввод!\n");
                        break;
                }
            }
            if (SomeApp.DisplayApp()) {
                return true;
            }
            return false;
        }
    }
}