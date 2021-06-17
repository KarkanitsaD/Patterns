using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итератор
{
    public class Library: IBookNumerable
    {

        private Book[] books;

        public Book this[int index] => books[index];

        public int Count
        {
            get
            {
                return books.Length;
            }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
