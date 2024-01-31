using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUpAndLogIn {
    internal class UserAccount{
        static public void AddAccount()
        {   
            Form.DisplaySingUpForm();
            AccountList.AddAccount(Form.login, Form.password);
        }
        static public bool LogIn()
        {
            Form.DisplaySingUpForm();
            return AccountList.FindAnAccount(Form.login, Form.password);
        }
    }
}