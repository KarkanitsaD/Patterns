using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стратегия
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Dima", Email = "dima@mail.ru", Password = "123456" };
            user.HashStrategy = new PasswordHash();
            Console.WriteLine(user.HashStrategy.GetHash(user));

            user.HashStrategy = new EmailPasswordHash();
            Console.WriteLine(user.HashStrategy.GetHash(user));

            Console.ReadKey();
        }
    }
}
