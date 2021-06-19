﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public interface IVisitor
    {
        void VisitPersonAcc(PersonAccount account);
        void VisitCompanyAcc(CompanyAccount account);
    }
}
