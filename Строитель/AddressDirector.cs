using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строитель
{
    public class AddressDirector
    {
        IAddressBuilder addressBuilder;

        public IAddressBuilder AddressBuilder
        {
            set
            {
                addressBuilder = value;
            }
        }

        public AddressDirector(IAddressBuilder addressBuilder)
        {
            this.addressBuilder = addressBuilder;
        }

        public AddressDirector()
        {

        }

        public void BuldMinimalValueProduct(string city,  string street, string house)
        {
            addressBuilder.SetCountry()
                .SetCity(city)
                .SetStreet(street)
                .SetHouse(house);
        }

    }
}
