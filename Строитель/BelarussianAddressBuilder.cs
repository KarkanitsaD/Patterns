using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строитель
{
    public class BelarussianAddressBuilder: IAddressBuilder
    {
        Address address;

        public BelarussianAddressBuilder()
        {
            this.ResetAddress();
        }

        public Address GetAddress()
        {
            Address address = this.address;
            this.ResetAddress();
            return address;
        }

        public IAddressBuilder SetCity(string part)
        {
            address.AddPart("city", part);
            return this;
        }

        public IAddressBuilder SetCountry()
        {
            address.AddPart("country", "Belarus");
            return this;
        }

        public IAddressBuilder SetFlat(string part)
        {
            address.AddPart("flat", part);
            return this;
        }

        public IAddressBuilder SetFloor(string part)
        {
            address.AddPart("floor", part);
            return this;
        }

        public IAddressBuilder SetHouse(string part)
        {
            address.AddPart("house", part);
            return this;
        }

        public IAddressBuilder SetPostIndex(string part)
        {
            address.AddPart("postIndex", part);
            return this;
        }

        public IAddressBuilder SetStreet(string part)
        {
            address.AddPart("street", part);
            return this;
        }

        private void ResetAddress()
        {
            address = new Address();
        }


    }
}
