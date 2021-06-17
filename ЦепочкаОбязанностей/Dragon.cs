using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦепочкаОбязанностей
{
    public class Dragon : IEnemy
    {
        public int HealthPoints { get; set; }

        public Dragon(int health)
        {
            HealthPoints = health;
        }
    }
}
