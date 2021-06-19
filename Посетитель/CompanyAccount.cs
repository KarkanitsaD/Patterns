using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public class CompanyAccount: IAccount
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAcc(this);
        }

        public string Name { get; set; }
        public string PersonalAmount { get; set; }


    }
}
