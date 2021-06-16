using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShop shop = new BookShop() { Title = "Красная книга"};
            shop.AddBook("Harry potter 1");
            shop.AddBook("Lord of the ring 3");
            shop.AddBook("Witcher 3");

            Person person = new Person() { Name = "Dmitry", Surname = "Karkanitsa" };
            shop.AddObserver(person);

            shop.AddBook("Naruto Shipudden");
            shop.AddBook("Naruto Shipudden");
            shop.AddBook("Naruto Shipudden");

            Console.ReadKey();
        }
    }
}
