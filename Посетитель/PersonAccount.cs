using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public class PersonAccount : IAccount
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }


        public string Name { get; set; }
        public string Age { get; set; }
    }
}
