using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хранитель
{
    public class HeroMomento
    {
        public int Lives { get; private set; }
        public int Patrons { get; private set; }

        public HeroMomento(int lives, int patrons)
        {
            Lives = lives;
            Patrons = patrons;
        }
    }
}
