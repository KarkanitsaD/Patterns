using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хранитель
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot();
            hero.Shoot();
            hero.Shoot();
            hero.Shoot();


            GameHistory history = new GameHistory();
            history.History.Push(hero.SaveState());

            hero.Shoot();
            hero.Shoot();
            hero.Shoot();

            hero.RestoreState(history.History.Pop());
            hero.Shoot();

            Console.Read();
        }
    }
}
