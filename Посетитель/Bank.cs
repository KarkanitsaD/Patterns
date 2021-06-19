using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public class Bank
    {
        private List<IAccount> accounts = new List<IAccount>();
        public void AddAccount(IAccount account)
        {
            accounts.Add(account);
        }


        public void Accept(IVisitor visitor)
        {
            foreach(var a in accounts)
            {
                a.Accept(visitor);
            }
        }

    }
}
