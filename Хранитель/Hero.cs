using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хранитель
{
    public class Hero
    {
        private int patrons = 20;
        private int lives = 15;

        public void Shoot()
        {
            if(patrons > 0)
            {
                patrons--;
                Console.WriteLine($"У героя осталось {patrons} патронов.");
            }
            else
            {
                Console.WriteLine("Патронов нет!");
            }
        }

        public HeroMomento SaveState()
        {
            Console.WriteLine("Сотояние сохранено.");
            return new HeroMomento(lives, patrons);
        }

        public void RestoreState(HeroMomento heroMomento)
        {
            lives = heroMomento.Lives;
            patrons = heroMomento.Patrons;

            Console.WriteLine($"Состояние восстановлено. У героя осталось {patrons} патронов.");
        }

    }
}
