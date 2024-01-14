using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    internal class MainMenu {
        static public void DisplayMenu()
        {
            while (true) {
                Console.Clear();
                //Console.WriteLine("Главное меню\n");

                Console.WriteLine("Выберите режим:\n" +
                    "sign up\t- зарегистрироваться;\n" +
                    "log in\t- войти;\n" +
                    "exit\t- завершить работу\n");

                switch (Console.ReadLine()) {
                    case ("sign up"):
                        AccountList.AddAccount();
                        break;

                    case ("log in"):
                        AccountList.LogIn();
                        break;

                    case ("exit"):
                        return;

                    default:                       
                        Console.WriteLine("Допущена ошибка! Повторите ввод!\n");
                        break;
                }
            }
        }
    }
}
