using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЦепочкаОбязанностей
{
    public abstract class AbstractHero: IHero
    {       
        public IHero NextHero { get; set; }

        protected int healthPoint { get; set; }
        public int HealthPoint
        {
            get
            {
                return healthPoint;
            }
            set
            {
                healthPoint = value;
            }
        }
        public AbstractHero()
        {

        }
        public AbstractHero(int healthPoint)
        {
            this.healthPoint = healthPoint;
        }

        public void SetNextHero(IHero hero)
        {
            NextHero = hero;
        }

        public virtual bool Handle(IEnemy enemy)
        {
            if(NextHero != null)
            {
                return NextHero.Handle(enemy);
            }
            return false;
        }
    }
}
