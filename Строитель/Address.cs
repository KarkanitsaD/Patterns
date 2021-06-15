using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строитель
{
    public class Address
    {

        private Dictionary<string, string> addressComponents = new Dictionary<string, string>();

        public void AddPart(string partName, string part)
        {
            try
            {
                addressComponents.Add(partName, part);
            }catch(Exception ex)
            {
                //logging
            }
            
        }

    }
}
