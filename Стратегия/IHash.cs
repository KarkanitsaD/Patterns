using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стратегия
{
    public interface IHash
    {
        string GetHash(User user);
    }
}
