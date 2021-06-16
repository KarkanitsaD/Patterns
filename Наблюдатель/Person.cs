using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public class Person: IObserver
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Update(IObservable observable)
        {
            if(observable is BookShop)
            {
                Console.WriteLine($"Спсибо магазину {((BookShop)observable).Title} за уведомление!");
            }
        }
    }
}
