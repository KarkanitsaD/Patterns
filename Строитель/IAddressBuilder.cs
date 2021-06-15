using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строитель
{
    public interface IAddressBuilder
    {
        IAddressBuilder SetCountry();
        IAddressBuilder SetCity(string part);
        IAddressBuilder SetStreet(string part);
        IAddressBuilder SetHouse(string part);
        IAddressBuilder SetFlat(string part);
        IAddressBuilder SetFloor(string part);
        IAddressBuilder SetPostIndex(string part);
        Address GetAddress();
    }
}
