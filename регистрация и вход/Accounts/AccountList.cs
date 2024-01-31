using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUpAndLogIn {
    class AccountList {
        static protected List<Account> accounts = new List<Account>();

        static public void AddAccount(string login, string password)
        {
            accounts.Add(new Account(login, password));
        }
        static public bool FindAnAccount(string login, string password)
        {
            foreach (Account acc in accounts) {
                if (acc.Login == login && acc.Password == password) {
                    return true;
                }
            }
            return false;
        }
    }
}