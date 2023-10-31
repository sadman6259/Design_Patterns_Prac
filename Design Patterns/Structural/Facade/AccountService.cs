using Design_Patterns.Structural.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural.Facade
{
    class AccountService : IAccount
    {
        public string GetAccountInfo()
        {
            return "Account Info Retrieved";
        }

    }
}
