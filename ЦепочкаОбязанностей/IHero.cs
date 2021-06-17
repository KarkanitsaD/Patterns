using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦепочкаОбязанностей
{
    public interface IHero
    {
        int HealthPoint { get; set; }
        void SetNextHero(IHero hero);
        bool Handle(IEnemy enemy);
    }
}
