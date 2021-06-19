using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public class XmlVisitor : IVisitor
    {
        public void VisitCompanyAcc(CompanyAccount account)
        {
            string result = $"<CompanyAccount><Name>{account.Name}</Name><PersonalAmount>{account.PersonalAmount}</PersonalAmount></CompanyAccount>";
            Console.WriteLine(result);
        }

        public void VisitPersonAcc(PersonAccount account)
        {
            string result = $"<PersonAccount><Name>{account.Name}</Name><Age>{account.Age}</Age></PersonAccount>";
            Console.WriteLine(result);
        }
    }
}
