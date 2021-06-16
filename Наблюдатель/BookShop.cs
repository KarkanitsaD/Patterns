using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public class BookShop : IObservable
    {
        public string Title { get; set; }
        public List<string> Books = new List<string>();
        public List<IObserver> Observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void AddBook(string book)
        {
            Books.Add(book);
            Notify();
        }

        public void Notify()
        {
            foreach(var obs in Observers)
            {
                obs.Update(this);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
