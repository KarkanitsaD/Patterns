using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строитель
{
    class Program
    {
        static void Main(string[] args)
        {
            IAddressBuilder addressBuilder = new BelarussianAddressBuilder();
            AddressDirector addressDirector = new AddressDirector(addressBuilder);
            addressDirector.BuldMinimalValueProduct("Grodno", "Belye Rosy", "45");

            var address = addressBuilder.GetAddress();

            Console.WriteLine();
        }
    }
}
