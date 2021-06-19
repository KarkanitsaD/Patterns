using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AddAccount(new PersonAccount() { Age = "12", Name = "Vova" });
            bank.AddAccount(new CompanyAccount() { Name = "Company 1", PersonalAmount = "60" });

            bank.Accept(new XmlVisitor());

            Console.Read();

        }
    }
}
