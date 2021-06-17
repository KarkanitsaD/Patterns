using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Медиатор
{
    class Program
    {
        static void Main(string[] args)
        {
            ITManager manager = new ITManager();
            Programmer programmer = new Programmer(manager);
            Customer customer = new Customer(manager);
            Tester tester = new Tester(manager);

            manager.Tester = tester;
            manager.Customer = customer;
            manager.Programmer = programmer;

            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");

            Console.Read();
        }
    }
}
