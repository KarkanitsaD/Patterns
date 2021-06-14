using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФабричныйМетод
{
    public abstract class HouseFactory
    {
        public string Name { get; set; }
        public HouseFactory(string name)
        {
            Name = name;
        }
        public abstract House BuildHouse();
    }
}
