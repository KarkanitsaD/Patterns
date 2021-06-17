using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦепочкаОбязанностей
{
    public class Knight: AbstractHero
    {
        public string Name { get; set; }
        public Knight(string name, int healthPoint): base(healthPoint)
        {
            Name = name;
        }

        public override bool Handle(IEnemy enemy)
        {
            if(base.healthPoint < enemy.HealthPoints)
            {
                enemy.HealthPoints -= healthPoint;
                base.healthPoint = 0;
                Console.WriteLine($"{Name} could not win enemy!");
                return base.Handle(enemy);
            }
            else
            {
                base.healthPoint -= enemy.HealthPoints;
                enemy.HealthPoints = 0;
                Console.WriteLine($"{Name} won enemy!");
                return true;
            }
        }
    }
}
