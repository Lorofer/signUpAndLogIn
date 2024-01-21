using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регистрация_и_вход {
    internal class AccountList {
        static private List<Account> accounts = new List<Account>();

        static public void AddAccount(string login, string password)
        {
            Account newAccount = new Account { Login = login, Password = password };
            accounts.Add(newAccount);
        }

        static public bool FindAnAccount(string login, string password)
        {
            foreach(Account acc in accounts) {
                if(acc.Login == login && acc.Password == password) {
                    return true;
                }
            }
            return false;
        }
    }   
}